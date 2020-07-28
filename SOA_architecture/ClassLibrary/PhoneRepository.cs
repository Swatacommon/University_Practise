using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary
{

    sealed public class PhoneRepository : IRepository<Phone>
    {
        DbContext db = new DbContext();

        public void Add(Phone item)
        {
            db.Phones.Add(item);
            db.SaveChanges();
        }

        public void Dispose()
        {
            
        }

        public IEnumerable<Phone> GetAll()
        { 
            return db.Phones;
        }

        public bool Remove(Phone item)
        {
            if (item == null)
            {
                return false;
            }
            db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return true;
        }

        public void Update(Phone item)
        {
            var phone = Get(item.Id);
            phone.Last_name = item.Last_name;
            phone.Phone_number = item.Phone_number;
            db.SaveChanges();
        }

        public Phone Get(int ID)
        {
            return db.Phones.FirstOrDefault(t => t.Id == ID);
        }

    }
}