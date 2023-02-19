using FamilyEventt.Models;

namespace FamilyEventt.Dto
{
    public class StaffDto
    {
        public int StaffId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public bool Status { get; set; }

       // public virtual Role Role { get; set; }
       // public virtual ICollection<ChatMessage> ChatMessage { get; set; }
    }
}
