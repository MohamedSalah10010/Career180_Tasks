using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Online_Shopping.Models;

namespace Online_Shopping.Repos
{
    public class GenericRepo<genericEntity> where genericEntity : class
    {
       public shopContext db;
        public GenericRepo(shopContext db) { this.db = db; }

        public List<genericEntity> selectAll() 
        { 
            return db.Set<genericEntity>().ToList();
        }

        public genericEntity selectById(int id)
        {
            return db.Set<genericEntity>().Find(id);
        }

        public void add(genericEntity entity)
        {
            db.Set<genericEntity>().Add(entity);
            //return entity;
        }

        public void update(genericEntity entity) {

            db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
           //return entity;   
        }
        public void remove(int id) 
        {

            var obj = db.Set<genericEntity>().Find(id);
            db.Set<genericEntity>().Remove(obj);
          
        }

        public void save() 
        { 
        
            db.SaveChanges();
        }
    
    }
}
