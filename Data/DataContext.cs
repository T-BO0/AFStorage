using AFStorage.Models;
using Microsoft.EntityFrameworkCore;

namespace AFStorage.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     base.OnConfiguring(optionsBuilder);
        //     optionsBuilder.UseSqlServer("Server=DESKTOP-51T7GLU\\SQLExpress;DataBase=acstorage;Trusted_Connection=true;TrustServerCertificate=true;");
        // }
        public DbSet<ACEngine> ACEngine { get; set; }
        public DbSet<ACFuel> ACFuels { get; set; }

    }
}