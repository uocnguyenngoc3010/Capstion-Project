using System.ComponentModel.DataAnnotations;

namespace FamilyEventt.Dto
{
    public class DrinkDto
    {
        [Required]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public long Price { get; set; }
        public string Detail { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
    }
}
