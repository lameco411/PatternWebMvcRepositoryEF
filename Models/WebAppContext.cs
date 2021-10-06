using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models.Class;
//using Microsoft.Extensions.Options;
using WebApp.Models.Configs;

namespace WebApp.Models
{
    public class WebAppContext : DbContext
    {       
        readonly IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json").Build();
        readonly string connectionString;
        public WebAppContext()
        {
            connectionString = configuration.GetConnectionString("WebAppConnection");
        }
        //loging for change 
        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddFilter(DbLoggerCategory.Query.Name, Microsoft.Extensions.Logging.LogLevel.Information);
            builder.AddFilter(DbLoggerCategory.Database.Name, Microsoft.Extensions.Logging.LogLevel.Information);
            builder.AddConsole();
        });
        // danh sách các dbset ở đây, ví dụ:
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLoggerFactory(loggerFactory);
            optionsBuilder.UseSqlServer(connectionString);
            //optionsBuilder.UseMySQL(_connection.Value.WebAppConnection);
            //optionsBuilder.UseLazyLoadingProxies(); sử dụng lazy loading, không khuyến khích
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Console.WriteLine("On Model Creating");
        }
    }
}
