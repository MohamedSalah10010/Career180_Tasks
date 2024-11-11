using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Shopping.DTOs;
using Online_Shopping.Models;
using Online_Shopping.Repos;
using Online_Shopping_v2.DTOs;
using Online_Shopping_v2.UnitOfWork;
using System.IO;
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
                unit.Save();
                //return Ok(selectAllProduct());
                return Ok(prodDTO);
            }

        }
        
        [HttpPost]
        public IActionResult addProduct([FromForm] addProductDTO product)
        {
            //Console.WriteLine($"Received product: {product.name}, {product.price}, {product.cat_id}");

            if (product == null)
            {
                //Console.WriteLine( "product is null" );
                    return NotFound(); 
            }
            else
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "uploads/");
                string finalpath = Path.Combine(path, product.ProductPhoto.FileName);
                FileStream str = new FileStream(finalpath, FileMode.Create);
                product.ProductPhoto.CopyTo(str);//upload photo to folder"",

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

        [HttpPut("{id}")]
        public IActionResult editProduct(int id,[FromForm] addProductDTO product)
        {
       
            if (product == null) return NotFound();
            if (id != product.ProductId) return BadRequest();

            if (ModelState.IsValid)
            {
                string finalpath;
                FileStream str=null;

                if (product.ProductPhoto != null)
                {
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "uploads/");
                    finalpath = Path.Combine(path, product.ProductPhoto.FileName);
                    str = new FileStream(finalpath, FileMode.Create);
                }
                else 
                {
                    finalpath = null; 
                }
                Product prod = new Product()
                {

                    id = id,
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
                    ProductPhotoPath = prod.photoPath
                };

                product.ProductPhoto.CopyTo(str);//upload photo to folder"",

                unit.ProdRepo.update(prod);
                unit.Save();

                return CreatedAtAction("selectProductById", new { id = prod.id},prodDTO);
            }
            else return BadRequest(ModelState);
            
        }

    }
}
