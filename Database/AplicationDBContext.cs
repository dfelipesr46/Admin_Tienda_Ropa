using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _02_TiendaDeRopa.Models;
using Microsoft.EntityFrameworkCore;

namespace _02_TiendaDeRopa.Database
{
    public class AplicationDBContext : DbContext
    {
        public AplicationDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Producto> Productos {get; set;}
    }
}