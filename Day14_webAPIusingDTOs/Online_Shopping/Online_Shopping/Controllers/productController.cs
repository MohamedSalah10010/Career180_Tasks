using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Shopping.DTOs;
using Online_Shopping.Models;

namespace Online_Shopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productController : ControllerBase
    {
        shopContext db;
        public productController(shopContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult selectAllProduct() {
            //Console.WriteLine("selectALLLLLLLLLLLLLLLLLLLLLL");
            List<Product> products = db.Products.ToList();
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
            Product product = db.Products.Find(id);
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
            List<Product> products = db.Products.Where(p => p.price == price).ToList();
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
            Product product = db.Products.Find(id);

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
                db.Products.Remove(product);
                db.SaveChanges();
                return Ok(db.Products.ToList());
            }

        }
        
        
        [HttpPost]
        public IActionResult addProduct([FromBody] Product product)
        {
            Console.WriteLine($"Received product: {product.name}, {product.price}, {product.cat_id}");

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
                    ProductCategoryName = db.Catalogs.Where(p => p.id == product.cat_id).Select(p => p.name).SingleOrDefault(),
                    ProductPrice = product.price,
                    ProductQuantity = product.amount
                };
                //Console.WriteLine(  "i'm being addded");
                db.Products.Add(product);
                //Console.WriteLine( "i have been added sucessfully" );
                db.SaveChanges();
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
                db.Entry(product).State = EntityState.Modified;
                productDTO prodDTO = new productDTO()
                {
                    ProductId = product.id,
                    ProductName = product.name,
                    ProductDescription = product.desc,
                    ProductCategoryName = db.Catalogs.Where(p => p.id == product.cat_id).Select(p => p.name).SingleOrDefault(),
                    ProductPrice = product.price,
                    ProductQuantity = product.amount
                };
                db.SaveChanges();

                return CreatedAtAction("selectProductById", new { id = product.id},prodDTO);
            }
            else return BadRequest(ModelState);
            
               
          

        }

    }
}
