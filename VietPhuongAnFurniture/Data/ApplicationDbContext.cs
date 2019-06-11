using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VietPhuongAnFurniture.Models;

namespace VietPhuongAnFurniture.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductSubType> ProductSubTypes { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Telephone> Telephones { get; set; }
        public DbSet<Website> Websites { get; set; }

    }
}
