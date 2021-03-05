using LibraryV2.Models.Entities;
using System.Data.Entity;

namespace LibraryV2.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext():base("ConnectionString")
        {
        }
        // Tabele baz danych
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<Identities> Identities { get; set; }
        public DbSet<Restrictions> Restrictions { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<States> States { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
