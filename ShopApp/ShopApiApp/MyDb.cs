using Microsoft.EntityFrameworkCore;
using ShopApiApp.Model;

namespace ShopApiApp
{
    public class MyDb:DbContext
    {
        public MyDb(DbContextOptions<MyDb> options) : base(options)
        {

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var sqlConnStr = "Data Source=DESKTOP-Q53V3V6\\SQLEXPRESS;Database=DbShop;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        //    optionsBuilder.UseSqlServer(sqlConnStr);
        //}
    }
}
