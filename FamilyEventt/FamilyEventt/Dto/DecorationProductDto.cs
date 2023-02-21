using FamilyEventt.Models;

namespace FamilyEventt.Dto
{
    public class DecorationProductDto
    {
        public int DecorationId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public DecorationDto Decoration { get; set; }
        public ProductDto Product { get; set; }
    }
}
