using FamilyEventt.Models;

namespace FamilyEventt.Dto
{
    public class EntertainmentDto
    {
        public int EntertainmentId { get; set; }
        public bool Status { get; set; }
        public int EventId { get; set; }
        public decimal Total { get; set; }

        //public virtual Event Event { get; set; }
       // public virtual ICollection<EntertainmentProduct> EntertainmentProduct { get; set; }
    }
}
