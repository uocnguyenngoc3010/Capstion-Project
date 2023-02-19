using FamilyEventt.Models;

namespace FamilyEventt.Dto
{
    public class ShowDto
    {
        public int ShowId { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string Light { get; set; }
        public string Sound { get; set; }
        public string Singer { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }

        //public virtual ICollection<EntertainmentProduct> EntertainmentProduct { get; set; }
    }
}
