using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary
{
    sealed public class CatRepository : IRepository<Cat>
    {
        DbContext db = new DbContext();

        public void Add(Cat item)
        {
            db.Cats.Add(item);
            db.SaveChanges();
        }

        public void Dispose()
        {
        }

        public Cat Get(int ID)
        {
            return db.Cats.FirstOrDefault(t => t.Id == ID);
        }

        public IEnumerable<Cat> GetAll()
        {
            return db.Cats;
        }

        public bool Remove(Cat item)
        {
            if (item == null)
            {
                return false;
            }
            db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return true;
        }

        public void Update(Cat item)
        {
            var cat = Get(item.Id);
            cat.Name = item.Name;
            cat.Breed = item.Breed;
            db.SaveChanges();
        }
    }
}
