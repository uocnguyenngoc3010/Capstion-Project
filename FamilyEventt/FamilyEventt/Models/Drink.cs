﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FamilyEventt.Models
{
    public partial class Drink
    {
        public Drink()
        {
            MenuDrink = new HashSet<MenuDrink>();
            MenuProduct = new HashSet<MenuProduct>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public long Price { get; set; }
        public string Detail { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<MenuDrink> MenuDrink { get; set; }
        public virtual ICollection<MenuProduct> MenuProduct { get; set; }
    }
}