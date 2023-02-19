using FamilyEventt.Models;

namespace FamilyEventt.Dto
{
    public class MenuProductDto
    {
        public int MenuId { get; set; }
        public int Product { get; set; }
        public int Quatity { get; set; }
        public decimal Price { get; set; }
        public bool Type { get; set; }

      //  public virtual Menu Menu { get; set; }
        //public virtual Food Product1 { get; set; }
       // public virtual Drink ProductNavigation { get; set; }
    }
}
