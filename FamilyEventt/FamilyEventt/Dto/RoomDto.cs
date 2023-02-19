using FamilyEventt.Models;

namespace FamilyEventt.Dto
{
    public class RoomDto
    {
        public int RoomId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public bool Status { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }

        //public virtual ICollection<DateTimeLocation> DateTimeLocation { get; set; }
        //public virtual ICollection<Event> Event { get; set; }
    }
}
