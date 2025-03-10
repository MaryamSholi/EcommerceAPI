﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Core.Entities
{
    public class Products
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string? Image {  get; set; }
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public virtual Categories Category { get; set; }//navigation prop لحتى يفهم انو في ريلاشن
        public virtual ICollection<OrderDetails>? OrderDetails { get; set; } = new HashSet<OrderDetails>();
    }
}
