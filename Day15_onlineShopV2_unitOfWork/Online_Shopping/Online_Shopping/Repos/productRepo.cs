using Online_Shopping.Models;
using System.Security.Principal;

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

        public override void update(Product product) // update the changed and non-null values only
        {
            var existingEntity = product;
            if (existingEntity != null)
            {
                var properties = typeof(Product).GetProperties();

                foreach (var property in properties)
                {
                    if (property.Name == "id" || property.Name == "catalog") continue;
                    var newValue = property.GetValue(product);



                    // Check for default values based on property type
                    if (property.PropertyType == typeof(string) && newValue == null)
                    {
                        continue;
                    }
                    else if (property.PropertyType == typeof(int) && (int)newValue == 0)
                    {
                        continue;
                    }
                    else if (property.PropertyType == typeof(decimal) && (decimal)newValue == 0)
                    {
                        continue;
                    }
                    else  
                    {
                        property.SetValue(existingEntity, newValue);
                        db.Entry(existingEntity).Property(property.Name).IsModified = true;
                    }
                }
            }


        }
    }
}
