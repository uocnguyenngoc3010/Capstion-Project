using FamilyEventt.Models;

namespace FamilyEventt.Dto
{
    public class MenuDto
    {
        public int MenuId { get; set; }
        public bool Status { get; set; }
        public int EventId { get; set; }
        public decimal PriceTotal { get; set; }

        public virtual Event Event { get; set; }
        //public virtual ICollection<MenuDrink> MenuDrink { get; set; }
        //public virtual ICollection<MenuProduct> MenuProduct { get; set; }
    }
}
