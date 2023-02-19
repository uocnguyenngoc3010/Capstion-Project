using FamilyEventt.Models;

namespace FamilyEventt.Dto
{
    public class EventTypeDto
    {
        public int EventTypeId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        /*public virtual ICollection<Event> Event { get; set; }
        public virtual ICollection<Script> Script { get; set; }*/
    }
}
