using FamilyEventt.Models;

namespace FamilyEventt.Dto
{
    public class FoodDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Dish { get; set; }
        public decimal Price { get; set; }
        public string ComboFood { get; set; }
        public string Description { get; set; }
        public string Ingredient { get; set; }
        public string Origin { get; set; }
        public string CookingRecipe { get; set; }
        public string Image { get; set; }
        public int FoodTypeId { get; set; }
        public bool Status { get; set; }

        //public virtual FoodType FoodType { get; set; }
      //  public virtual ICollection<MenuProduct> MenuProduct { get; set; }
    }
}
