using FamilyEventt.Models;

namespace FamilyEventt.Dto
{
    public class DecorationDto
    {
        public int DecorationId { get; set; }
        public string DecorationName { get; set; }
        public decimal DecorationPrice { get; set; }
        //public string DecorationCombo { get; set; }
        public string DecorationImage { get; set; }

        //public virtual ICollection<DecorationProduct> DecorationProduct { get; set; }
        //public virtual ICollection<Event> Event { get; set; }
    }
}
