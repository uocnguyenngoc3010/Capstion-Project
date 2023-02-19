using FamilyEventt.Models;

namespace FamilyEventt.Dto
{
    public class DecorationProductDto
    {
        public int DecorationId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        //public virtual Decoration Decoration { get; set; }
        //public virtual Product Product { get; set; }
    }
}
