﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FamilyEventt.Models
{
    public partial class Game
    {
        public Game()
        {
            EntertainmentProduct = new HashSet<EntertainmentProduct>();
        }

        public int GameId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Details { get; set; }
        public string Rules { get; set; }
        public string Reward { get; set; }
        public string Supplies { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<EntertainmentProduct> EntertainmentProduct { get; set; }
    }
}