namespace FamilyEventt.Dto
{
    public class LocationDto
    {
        public int LocationId { get; set; }
        public int RoomId { get; set; } 
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int QuantityParticipants { get; set; }
        
        public bool Status { get; set; }
        
    }
}
