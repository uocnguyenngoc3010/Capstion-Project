using FamilyEventt.Models;

namespace FamilyEventt.Dto
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public string? ProductDetails { get; set; }
        public string? ProductImage { get; set; }
        public string? ProductSupplier { get; set; }
        public bool Status { get; set; }

        // public virtual ICollection<DecorationProduct> DecorationProduct { get; set; }
    }
}
