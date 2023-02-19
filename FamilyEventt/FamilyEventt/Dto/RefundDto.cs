using FamilyEventt.Models;

namespace FamilyEventt.Dto
{
    public class RefundDto
    {
        public int RefundId { get; set; }
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        //public virtual Payment Payment { get; set; }
    }
}
