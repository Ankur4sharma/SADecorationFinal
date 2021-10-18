using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SADecoration.Models;

namespace SADecoration.Data
{
    public class SADecorationContext : DbContext
    {
        public SADecorationContext (DbContextOptions<SADecorationContext> options)
            : base(options)
        {
        }

        public DbSet<SADecoration.Models.Login> Login { get; set; }

        public DbSet<SADecoration.Models.Products> Products { get; set; }

        public DbSet<SADecoration.Models.Contact> Contact { get; set; }

        public DbSet<SADecoration.Models.Stock> Stock { get; set; }
    }
}
