﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FamilyEventt.Models
{
    public partial class ChatMessage
    {
        public int ChatId { get; set; }
        public int EventBookerId { get; set; }
        public int StaffId { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }

        public virtual EventBooker EventBooker { get; set; }
    }
}