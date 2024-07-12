﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public double Quantity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }



        public ICollection<Sale> Sales { get; set; }
    }
}
