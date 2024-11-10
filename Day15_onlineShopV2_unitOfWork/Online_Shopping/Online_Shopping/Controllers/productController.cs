using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Shopping.DTOs;
using Online_Shopping.Models;
using Online_Shopping.Repos;
using System.Security.Principal;

namespace Online_Shopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productController : ControllerBase
    {
        //GenericRepo<Product> prodRepo;
        productRepo prodRepo;
        catalogRepo cataRepo;
        public productController(productRepo prodRepo, catalogRepo cataRepo)
        {
            this.prodRepo = prodRepo;
            this.cataRepo = cataRepo;

        }

        [HttpGet]
        public IActionResult selectAllProduct() {
            //Console.WriteLine("selectALLLLLLLLLLLLLLLLLLLLLL");
            List<Product> products = prodRepo.selectAll();
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
                        ProductQuantity=product.amount


                    };
                    prodDTO.Add(product1);
                    
                }
                return Ok(prodDTO);
            }
        }

        [HttpGet("id{id:int}")]
        public IActionResult selectProductById(int id)
        {
            Product product = prodRepo.selectById(id);
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
                    ProductQuantity = product.amount
                };
                return Ok(prodDTO);
            }
                
        }

        [HttpGet("price{price}")]
        public IActionResult selectProductByPrice(decimal price)
        {
            List<Product> products = prodRepo.selectByPrice(price);
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

             Product product= prodRepo.selectById(id);

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
                prodRepo.remove(id);
                prodRepo.save();
                //return Ok(selectAllProduct());
                return Ok(prodDTO);
            }

        }
        
        [HttpPost]
        public IActionResult addProduct([FromBody] Product product)
        {
            //Console.WriteLine($"Received product: {product.name}, {product.price}, {product.cat_id}");

            if (product == null)
            {
                //Console.WriteLine( "product is null" );
                    return NotFound(); 
            }
            else
            {
                //Console.WriteLine( "product isnot null" );
                productDTO prodDTO = new productDTO()
                {
                    ProductId = product.id,
                    ProductName = product.name,
                    ProductDescription = product.desc,
                    ProductCategoryName = cataRepo.selectName(product.cat_id),
                    ProductPrice = product.price,
                    ProductQuantity = product.amount
                };
                //Console.WriteLine(  "i'm being addded");
                prodRepo.add(product);
                //Console.WriteLine( "i have been added sucessfully" );
                prodRepo.save();
                return CreatedAtAction("selectProductById", new { id = product.id},prodDTO);
                //return Ok();

            }
        }

        [HttpPut("{id}")]
        public IActionResult editProduct(int id, Product product)
        {
       
            if (product == null) return NotFound();
            if (id != product.id) return BadRequest();

            if (ModelState.IsValid)
            {
                prodRepo.update(product);
                productDTO prodDTO = new productDTO()
                {
                    ProductId = product.id,
                    ProductName = product.name,
                    ProductDescription = product.desc,
                    ProductCategoryName = cataRepo.selectName(product.cat_id),
                    ProductPrice = product.price,
                    ProductQuantity = product.amount
                };
                prodRepo.save();

                return CreatedAtAction("selectProductById", new { id = product.id},prodDTO);
            }
            else return BadRequest(ModelState);
            
        }

    }
}
