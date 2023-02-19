namespace FamilyEventt.Dto
{
    public class FeedbackDto
    {
        public int EventBookerId { get; set; }
        public int EventId { get; set; }
        public int Vote { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public string Reply { get; set; }
        public bool Status { get; set; }
    }
}
