using FamilyEventt.Models;

namespace FamilyEventt.Dto
{
    public class EntertainmentProductDto
    {
        public int EntertainmentId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

      //  public virtual Entertainment Entertainment { get; set; }
        //public virtual Game Product { get; set; }
       // public virtual Show ProductNavigation { get; set; }
    }
}
