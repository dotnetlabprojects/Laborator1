using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Laborator1.Models
{
    public class Product
    {
        //[Key()]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [Range(1, 700)]
        public double Price { get; set; }
        public string Category { get; set; }

    }
}
