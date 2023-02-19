using FamilyEventt.Models;

namespace FamilyEventt.Dto
{
    public class FoodTypeDto
    {
        public int FoodTypeId { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }

        //public virtual ICollection<Food> Food { get; set; }
    }
}
