using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models
{
    public class BethanysPieShopDbContext: DbContext
    {

        public BethanysPieShopDbContext(DbContextOptions<BethanysPieShopDbContext> options) : base(options){}
        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-JDMM5F1\\MSSQLSERVER01; Initial Catalog = BethanysPieShop8854;Integrated Security = SSPI ; TrustServerCertificate =True ");
        }
    }
}
