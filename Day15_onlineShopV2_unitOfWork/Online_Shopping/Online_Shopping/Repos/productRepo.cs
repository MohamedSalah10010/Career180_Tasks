using Online_Shopping.Models;

namespace Online_Shopping.Repos
{
    public class productRepo:GenericRepo<Product>
    {
        
        public productRepo(shopContext db):base(db) 
        {
                
        }

        public List<Product> selectByPrice(decimal price) {

            return db.Products.Where(n => n.price == price).ToList();
        }
        public Product selectByName(string name) { 
            return db.Products.Where(n => n.name == name).FirstOrDefault();
        }
    }
}
