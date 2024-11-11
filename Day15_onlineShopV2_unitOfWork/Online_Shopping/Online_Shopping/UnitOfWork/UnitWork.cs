using Online_Shopping.Repos;
using Online_Shopping.Models;

namespace Online_Shopping_v2.UnitOfWork
{
    public class UnitWork
    {
        GenericRepo<Product> generic_prodRepo;
        GenericRepo<Catalog> generic_cataRepo;
       
        productRepo prodRepo;
        catalogRepo cataRepo;

        shopContext db;

        public UnitWork(shopContext db)
        {
            this.db = db;
        }

        public GenericRepo<Product> Generic_prodRepo 
        {
            get 
            {
                if (generic_prodRepo == null) {

                    generic_prodRepo = new GenericRepo<Product>(db);
                }
                return generic_prodRepo ;
            }
        }
        public GenericRepo<Catalog> Generic_cataRepo
        {
            get
            {
                if (generic_cataRepo == null)
                {

                    generic_cataRepo = new GenericRepo<Catalog>(db);
                }
                return generic_cataRepo;
            }
        }

        public productRepo ProdRepo
        {
            get
            {
                if (prodRepo == null)
                {

                    prodRepo = new productRepo(db);
                }
                return prodRepo;
            }
        }

        public catalogRepo CataRepo
        {
            get
            {
                if (cataRepo == null)
                {

                    cataRepo = new catalogRepo(db);
                }
                return cataRepo;
            }
        }

        public void Save() {

            db.SaveChanges();
        }
    }
}
