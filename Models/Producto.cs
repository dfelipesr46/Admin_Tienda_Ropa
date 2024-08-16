using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _02_TiendaDeRopa.Models
{
    public class Producto
    {
        [Key]
        public int ProductId {get; set;}
        [Required]
        [MaxLength(120)]
        public string ProductName {get; set;}
        [Required]
        public int ProductPrice {get; set;}
        public string ProductCategory {get; set;}
    }
}