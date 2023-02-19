using FamilyEventt.Models;

namespace FamilyEventt.Dto
{
    public class ScriptDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public string ScriptContent { get; set; }
        public int EventType { get; set; }

        //public virtual EventType EventTypeNavigation { get; set; }
        //public virtual ICollection<Event> Event { get; set; }
    }
}
