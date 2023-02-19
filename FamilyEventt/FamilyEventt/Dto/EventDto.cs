using FamilyEventt.Models;

namespace FamilyEventt.Dto
{
    public class EventDto
    {
        public int EventId { get; set; }
        public int ScriptId { get; set; }
        public int RoomId { get; set; }
        public int DecorationId { get; set; }
        public int EventTypeId { get; set; }
        public int OrderId { get; set; }

        /*public virtual Decoration Decoration { get; set; }
        public virtual EventType EventType { get; set; }
        public virtual EventOrder Order { get; set; }
        public virtual Room Room { get; set; }
        public virtual Script Script { get; set; }
        public virtual ICollection<DateTimeLocation> DateTimeLocation { get; set; }
        public virtual ICollection<Entertainment> Entertainment { get; set; }
        public virtual ICollection<Menu> Menu { get; set; }*/
    }
}
