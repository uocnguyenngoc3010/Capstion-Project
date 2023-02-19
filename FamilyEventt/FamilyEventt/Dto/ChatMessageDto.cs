using FamilyEventt.Models;

namespace FamilyEventt.Dto
{
    public class ChatMessageDto
    {
        public int ChatId { get; set; }
        public int EventBookerId { get; set; }
        public int StaffId { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }

       // public virtual EventBooker EventBooker { get; set; }
        // public virtual Staff Staff { get; set; }
    }
}
