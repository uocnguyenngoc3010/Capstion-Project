using FamilyEventt.Models;

namespace FamilyEventt.Dto
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Details { get; set; }
        public string Image { get; set; }
        public string Supplier { get; set; }
        public bool Status { get; set; }

       // public virtual ICollection<DecorationProduct> DecorationProduct { get; set; }
    }
}
