using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_TiendaDeRopa.Models
{
    public class Producto
    {
        public int ProductId {get; set;}
        public string ProductName {get; set;}
        public int ProductPrice {get; set;}
        public string ProductCategory {get; set;}
    }
}