using EFCorePizzaShop.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePizzaShop.context
{
    public class PizzaShop:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-QL1TE6V\\SQLEXPRESS;Integrated Security=true;Initial Catalog=dbPizzaShop;");
        }
        public DbSet<Pizza> Pizza { get; set; }
    }
}
