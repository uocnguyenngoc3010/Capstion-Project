﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FamilyEventt.Models
{
    public partial class DateTimeLocation
    {
        public int EventId { get; set; }
        public int RoomId { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }

        public virtual Event Event { get; set; }
        public virtual Room Room { get; set; }
        public virtual DateTimeLocationStatus StatusNavigation { get; set; }
    }
}