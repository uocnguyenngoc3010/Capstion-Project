using FamilyEventt.Models;

namespace FamilyEventt.Dto
{
    public class MenuDrinkDto
    {
        public int MenuId { get; set; }
        public int DrinkId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public virtual Drink Drink { get; set; }
        public virtual Menu Menu { get; set; }
    }
}
