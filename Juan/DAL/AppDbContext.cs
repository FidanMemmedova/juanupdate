using Juan.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {}
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<ShoesCard> ShoesCards { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<ShopProduct> ShopProducts { get; set; }
    }
}
