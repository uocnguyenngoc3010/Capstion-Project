﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FamilyEventt.Models
{
    public partial class BookingRecord
    {
        public BookingRecord()
        {
            EventOrder = new HashSet<EventOrder>();
        }

        public int BookingRecordId { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<EventOrder> EventOrder { get; set; }
    }
}