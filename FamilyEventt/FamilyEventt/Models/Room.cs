// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FamilyEventt.Models
{
    public partial class Room
    {
        public Room()
        {
            DateTimeLocation = new HashSet<DateTimeLocation>();
        }

        public int RoomId { get; set; }
        public string Name { get; set; }
        public int Parking { get; set; }
        public int Capacity { get; set; }
        public bool Status { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }

        public virtual ICollection<DateTimeLocation> DateTimeLocation { get; set; }
    }
}