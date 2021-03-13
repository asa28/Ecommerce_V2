using Microsoft.EntityFrameworkCore;
using System;
using V2.DAL.Models;

namespace V2.DAL.DB_Context
{
    public class ECommerceDbContext: DbContext
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> opt) : base(opt) { }

        public DbSet<User>  Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}
