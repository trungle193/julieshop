using JulieShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulieShop.Infrastructure.Data
{
    public class JulieShopDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public JulieShopDbContext(DbContextOptions options) : base(options)
        {
        }

        protected JulieShopDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");
            });
        }
    }
}
