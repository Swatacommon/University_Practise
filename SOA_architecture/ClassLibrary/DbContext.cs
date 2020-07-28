using System.Data.Entity;

namespace ClassLibrary
{
    public class DbContext : System.Data.Entity.DbContext
    {
        public DbContext()
      : base("DbConnection")
        { }

        public DbSet<Phone> Phones { get; set; }
        public DbSet<Cat> Cats { get; set; }
    }
}
