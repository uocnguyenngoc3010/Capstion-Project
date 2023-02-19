using FamilyEventt.Models;

namespace FamilyEventt.Dto
{
    public class EventOrderDto
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public decimal PriceUnit { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string Payment { get; set; }
        public int EventBookerId { get; set; }
        public bool Status { get; set; }
        public int BookingRecordId { get; set; }

       /* public virtual BookingRecord BookingRecord { get; set; }
        public virtual EventBooker EventBooker { get; set; }
        public virtual ICollection<Event> Event { get; set; }
        public virtual ICollection<Payment> PaymentNavigation { get; set; }*/
    }
}
