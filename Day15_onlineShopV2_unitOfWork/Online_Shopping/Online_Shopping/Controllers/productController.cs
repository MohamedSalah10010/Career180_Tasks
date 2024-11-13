using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Shopping.DTOs;
using Online_Shopping.Models;
using Online_Shopping.Repos;
using Online_Shopping_v2.DTOs;
using Online_Shopping_v2.UnitOfWork;
using Swashbuckle.AspNetCore.Annotations;
using System.IO;
using System;
using System.Security.Principal;

namespace Online_Shopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productController : ControllerBase
    {
        UnitWork unit;
        public productController(UnitWork unit)
        {
            this.unit = unit;

        }

        [HttpGet]
        [SwaggerOperation
            (
            Summary = "Retrieves all products",
            Description = "Fetches a list of all available products in the system"
            )]
        [SwaggerResponse(200, "Successfully retrieved the list of products", typeof(List<productDTO>))]
        [SwaggerResponse(404, "No products found")]
        [Produces("application/json")]
        //[Consumes("application/json")]

        public IActionResult selectAllProduct() {
            //Console.WriteLine("selectALLLLLLLLLLLLLLLLLLLLLL");
            List<Product> products = unit.ProdRepo.selectAll();
            List<productDTO> prodDTO = new List<productDTO>();    
            if (products.Count < 0) return NotFound();
            else {
                foreach (Product product in products) {

                    productDTO product1 = new productDTO()
                    {
                        ProductId = product.id,
                        ProductName = product.name,
                        ProductDescription = product.desc,
                        ProductCategoryName=product.catalog.name,
                        ProductPrice = product.price,
                        ProductQuantity=product.amount,
                        ProductPhotoPath = product.photoPath


                    };
                    prodDTO.Add(product1);
                    
                }
                return Ok(prodDTO);
            }
        }

        [HttpGet("id{id:int}")]
        [SwaggerOperation(
         Summary = "Retrieves a product by ID",
         Description = "Fetches a single product's details based on its unique ID"
            )]
        [SwaggerResponse(200, "Successfully retrieved the product", typeof(productDTO))]
        [SwaggerResponse(404, "Product not found")]
        [Produces("application/json")]
        //[Consumes("application/json")]

        public IActionResult selectProductById(int id)
        {
            Product product = unit.ProdRepo.selectById(id);
            //Console.WriteLine("selectProductByIdselectProductByIdselectProductByIdselectProductById");
            
            if (product == null) return NotFound();
            else
            {
                productDTO prodDTO = new productDTO()
                {
                    ProductId = product.id,
                    ProductName = product.name,
                    ProductDescription = product.desc,
                    ProductCategoryName = product.catalog.name,
                    ProductPrice = product.price,
                    ProductQuantity = product.amount,
                    ProductPhotoPath=product.photoPath
                };
                return Ok(prodDTO);
            }
                
        }

        [HttpGet("price{price}")]
        [SwaggerOperation(
    Summary = "Retrieves products by price",
    Description = "Fetches a list of products that match the specified price"
        )]
        [SwaggerResponse(200, "Successfully retrieved products by price", typeof(List<productDTO>))]
        [SwaggerResponse(404, "No products found with the specified price")]
        [Produces("application/json")]

        public IActionResult selectProductByPrice(decimal price)
        {
            List<Product> products = unit.ProdRepo.selectByPrice(price);
            List<productDTO> prodDTO = new List<productDTO>();
            if (products.Count == 0) return NotFound();
            else
            {
                foreach (Product product in products)
                {

                    productDTO product1 = new productDTO()
                    {
                        ProductId = product.id,
                        ProductName = product.name,
                        ProductDescription = product.desc,
                        ProductCategoryName = product.catalog.name,
                        ProductPrice = product.price,
                        ProductQuantity = product.amount


                    };
                    prodDTO.Add(product1);

                }
                return Ok(prodDTO);
            }

        }

        [HttpDelete("{id}")]
        [SwaggerOperation(
    Summary = "Deletes a product",
    Description = "Deletes a product by its ID. Requires admin privileges"
        )]
        [SwaggerResponse(200, "Successfully deleted the product", typeof(productDTO))]
        [SwaggerResponse(404, "Product not found")]
        [Produces("application/json")]
        //[Consumes("application/json")]
        public IActionResult deleteProduct(int id)
        {

             Product product= unit.ProdRepo.selectById(id);

            if (product == null) return NotFound();
            else
            {
                productDTO prodDTO = new productDTO()
                {
                    ProductId = product.id,
                    ProductName = product.name,
                    ProductDescription = product.desc,
                    ProductCategoryName = product.catalog.name,
                    ProductPrice = product.price,
                    ProductQuantity = product.amount
                };
                unit.ProdRepo.remove(id);
                //FileStream del = new FileStream(product.photoPath, FileMode.Truncate);
                if(System.IO.File.Exists(product.photoPath)) System.IO.File.Delete(product.photoPath);
                
                unit.Save();
                //return Ok(selectAllProduct());
                return Ok(prodDTO);
            }

        }
        
        [HttpPost]
        [SwaggerOperation(
    Summary = "Creates a new product",
    Description = "Adds a new product to the system. Requires admin privileges."
)]
        [SwaggerResponse(201, "The product was created", typeof(productDTO))]
        [SwaggerResponse(400, "The product data is invalid")]
        [Produces("application/json")]
        //[Consumes("application/json")]
        public IActionResult addProduct([FromForm] addProductDTO product)
        {
            //Console.WriteLine($"Received product: {product.name}, {product.price}, {product.cat_id}");
            string finalpath = null;
            if (product == null)
            {
                //Console.WriteLine( "product is null" );
                    return NotFound(); 
            }
            else
            {
                if (product.ProductPhoto != null)
                {
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "uploads/");
                    finalpath = Path.Combine(path, product.ProductPhoto.FileName);
                    FileStream str  = new FileStream(finalpath, FileMode.Create);
                    product.ProductPhoto.CopyTo(str);//upload photo to folder""
                    str.Close();

                }
                //Console.WriteLine( "product isnot null" );
                Product prod = new Product()
                {
                    name = product.ProductName,
                    price = product.ProductPrice,
                    desc = product.ProductDescription,
                    amount = product.ProductQuantity,
                    photoPath = finalpath,
                    cat_id = product.ProductCategoryId


                };  
                
                
                productDTO prodDTO = new productDTO()
                {
                    ProductId = prod.id,
                    ProductName = prod.name,
                    ProductDescription = prod.desc,
                    ProductCategoryName = unit.CataRepo.selectName(prod.cat_id),
                    ProductPrice = prod.price,
                    ProductQuantity = prod.amount,
                    ProductPhotoPath=prod.photoPath
                   

                };
                //Console.WriteLine(  "i'm being addded");
                unit.ProdRepo.add(prod);
                

                //Console.WriteLine( "i have been added sucessfully" );
                unit.Save();
                return CreatedAtAction("selectProductById", new { id = prod.id},prodDTO);
                //return Ok();

            }
        }

        [HttpPut("editphoto/{id}")]
        [SwaggerOperation
            (
            Summary = "Updates the product photo",
            Description = "Updates the photo of an existing product by ID. Requires admin privileges."
             )]
        [SwaggerResponse(201, "Product photo updated successfully", typeof(productDTO))]
        [SwaggerResponse(400, "Invalid product ID or data")]
        [SwaggerResponse(404, "Product not found")]
        [Produces("application/json")]
        //[Consumes("application/json")]
        public IActionResult editProductPhoto(int id ,IFormFile photo)
        {
            Product product = unit.ProdRepo.selectById(id);
            if (product == null) return NotFound();
            if (id != product.id) return BadRequest();

            if (ModelState.IsValid)
            {
                string finalpath;
                FileStream str=null;

                if (photo != null)
                {
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "uploads/");
                    finalpath = Path.Combine(path, photo.FileName);
                    if (System.IO.File.Exists(product.photoPath)) System.IO.File.Delete(product.photoPath);
                    str = new FileStream(finalpath, FileMode.Create);
                   

                }
                else 
                {
                    finalpath = null; 
                }
                //Product prod = new Product()
                //{

                //    id = id,
                //    name = product.ProductName,
                //    price = product.ProductPrice,
                //    desc = product.ProductDescription,
                //    amount = product.ProductQuantity,
                //    photoPath = finalpath,
                //    cat_id = product.ProductCategoryId

                //};

                product.photoPath = finalpath;
                productDTO prodDTO = new productDTO()
                {
                    ProductId = product.id,
                    ProductName = product.name,
                    ProductDescription = product.desc,
                    ProductCategoryName = unit.CataRepo.selectName(product.cat_id),
                    ProductPrice = product.price,
                    ProductQuantity = product.amount,
                    ProductPhotoPath = finalpath
                };

                photo.CopyTo(str);//upload photo to folder"",
                str.Close();
                unit.ProdRepo.update(product);
                unit.Save();

                return CreatedAtAction("selectProductById", new { id = product.id},prodDTO);
            }
            else return BadRequest(ModelState);
            
        }

        [HttpPut("{id}")]
        [SwaggerOperation(
    Summary = "Updates product details",
    Description = "Edits the details of an existing product by ID. Requires admin privileges."
)]
        [SwaggerResponse(201, "Product updated successfully", typeof(productDTO))]
        [SwaggerResponse(400, "Invalid product ID or data")]
        [SwaggerResponse(404, "Product not found")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult editProduct(int id, Product product)
        {
            if (product == null) return NotFound();
            if (id != product.id) return BadRequest();

            if (ModelState.IsValid)
            {
                productDTO prodDTO = new productDTO()
                {
                    ProductId = product.id,
                    ProductName = product.name,
                    ProductDescription = product.desc,
                    ProductCategoryName = unit.CataRepo.selectName(product.cat_id),
                    ProductPrice = product.price,
                    ProductQuantity = product.amount,
                    ProductPhotoPath = product.photoPath
                };



                unit.ProdRepo.update(product);
                unit.Save();

                return CreatedAtAction("selectProductById", new { id = product.id }, prodDTO);
            }
            else return BadRequest(ModelState);

        }



    }
}
    
