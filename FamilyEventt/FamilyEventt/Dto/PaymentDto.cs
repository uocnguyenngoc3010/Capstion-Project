using FamilyEventt.Models;

namespace FamilyEventt.Dto
{
    public class PaymentDto
    {
        public int PaymentId { get; set; }
        public int EventOrderId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }

       // public virtual EventOrder EventOrder { get; set; }
       // public virtual ICollection<Refund> Refund { get; set; }
    }
}
