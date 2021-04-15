using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vkusno_Doma.Data.Models;

namespace Vkusno_Doma.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }
        public DbSet<Food> Food { get; set; }
        public DbSet<Category> Category { get; set; }

        public DbSet<FoodCartItem> foodCartItems { get; set; }

    }
}
