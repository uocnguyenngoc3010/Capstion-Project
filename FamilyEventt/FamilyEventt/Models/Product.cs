﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FamilyEventt.Models
{
    public partial class Product
    {
        public Product()
        {
            DecorationProduct = new HashSet<DecorationProduct>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Details { get; set; }
        public string Image { get; set; }
        public string Supplier { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<DecorationProduct> DecorationProduct { get; set; }
    }
}