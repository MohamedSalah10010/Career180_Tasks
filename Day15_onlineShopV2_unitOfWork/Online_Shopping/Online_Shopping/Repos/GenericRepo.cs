using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Online_Shopping.Models;

namespace Online_Shopping.Repos
{
    public class GenericRepo<genericEntity> where genericEntity : class
    {
       protected shopContext db;
        public GenericRepo(shopContext db) { this.db = db; }

        public virtual List<genericEntity> selectAll() 
        { 
            return db.Set<genericEntity>().ToList();
        }

        public virtual genericEntity selectById(int id)
        {
            return db.Set<genericEntity>().Find(id);
        }

        public virtual void add(genericEntity entity)
        {
            db.Set<genericEntity>().Add(entity);
            //return entity;
        }

        public virtual void update(genericEntity entity) {

            db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
           //return entity;   
        }
        public virtual void remove(int id) 
        {

            var obj = db.Set<genericEntity>().Find(id);
            db.Set<genericEntity>().Remove(obj);
          
        }

        public virtual void save() 
        { 
        
            db.SaveChanges();
        }
    
    }
}
