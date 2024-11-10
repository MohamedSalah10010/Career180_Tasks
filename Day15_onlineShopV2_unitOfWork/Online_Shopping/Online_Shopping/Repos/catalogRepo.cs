using Online_Shopping.Models;

namespace Online_Shopping.Repos
{
    public class catalogRepo:GenericRepo<Catalog>
    {
        
        public catalogRepo(shopContext db):base(db) 
        {
                
        }

        public string selectName(int id) { 
            return db.Catalogs.Where(p => p.id == id).Select(p => p.name).SingleOrDefault();
        }
    }
}
