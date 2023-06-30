using Microsoft.EntityFrameworkCore;
using Self_help_Webstore_GraphQL_API.src.Self_help_Webstore_GraphQL_API.Models;

namespace Self_help_Webstore_GraphQL_API.Self_help_Webstore_GraphQL_API.Web
{
    public class SelhelpWebstoreDBContext : DbContext
    {
        public SelhelpWebstoreDBContext(DbContextOptions<SelhelpWebstoreDBContext> options)
    : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
