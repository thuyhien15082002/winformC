using DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace DAL
{
    public class DBAccessDAL: DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<DetailOrder> DetailOrders { get; set; }

        public DbSet<Bill> Bills { get; set; }

        private const string ConnectionString = "Data Source=DESKTOP-UJM6TJ3;database=winform;User ID=sa;Password=123;TrustServerCertificate=true;Trusted_Connection=True;";


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString)
                          .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
        }


        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();

        }
        );
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Product
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Product) // Điều chỉnh để chỉ định navigation property ở phía many
                .HasForeignKey(p => p.CategoryID);

            // User
            modelBuilder.Entity<User>();

            // Account
            modelBuilder.Entity<Account>();

            // DetailOrder
            modelBuilder.Entity<DetailOrder>()
                .HasOne(de => de.Product)
                .WithMany(p => p.DetailOrder) // Điều chỉnh để chỉ định navigation property ở phía many
                .HasForeignKey(de => de.ProductID);

            modelBuilder.Entity<DetailOrder>()
                .HasOne(de => de.Bill)
                .WithMany(b => b.DetailOrder) // Điều chỉnh để chỉ định navigation property ở phía many
                .HasForeignKey(de => de.BillID);

            // Category
            modelBuilder.Entity<Category>();

            // Bill
            modelBuilder.Entity<Bill>()
                .HasOne(b => b.User)
                .WithMany(u => u.Bill) // Điều chỉnh để chỉ định navigation property ở phía many
                .HasForeignKey(b => b.UserID);

            modelBuilder.Entity<Bill>()
                .HasOne(b => b.Account)
                .WithMany(a => a.Bill) // Điều chỉnh để chỉ định navigation property ở phía many
                .HasForeignKey(b => b.AccountID);

            // Additional configurations for Bill relationships...

            // Rest of your configurations...
        }*/



    }

}
