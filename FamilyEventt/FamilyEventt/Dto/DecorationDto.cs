using FamilyEventt.Models;

namespace FamilyEventt.Dto
{
    public class DecorationDto
    {
        public int DecorationId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Combo { get; set; }
        public string Image { get; set; }

        //public virtual ICollection<DecorationProduct> DecorationProduct { get; set; }
        //public virtual ICollection<Event> Event { get; set; }
    }
}
