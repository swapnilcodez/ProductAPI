using Microsoft.EntityFrameworkCore;
using ProductAPI.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Data
{
    /// <summary>
    /// ProductDbContext
    /// </summary>
    public class ProductDbContext : DbContext
    {
        /// <summary>
        /// ProductDbContext
        /// </summary>
        /// <param name="options"></param>
        public ProductDbContext(DbContextOptions<ProductDbContext> options): base(options)
        {

        }

        /// <summary>
        /// Products
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// OnModelCreating
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {           
        }
    }
}
