using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class PhoneContext : DbContext
    {
        public PhoneContext()
      : base("DbConnection")
        { }

        public DbSet<Phone> Phones { get; set; }
    }
}
