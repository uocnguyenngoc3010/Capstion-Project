using FamilyEventt.Models;

namespace FamilyEventt.Dto
{
    public class DateTimeLocationDto
    {
        public int EventId { get; set; }
        public int RoomId { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }

        //public virtual Event Event { get; set; }
        //public virtual Room Room { get; set; }
        //public virtual DateTimeLocationStatus StatusNavigation { get; set; }
    }
}
