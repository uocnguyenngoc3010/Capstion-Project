using FamilyEventt.Models;
using System.ComponentModel.DataAnnotations;

namespace FamilyEventt.Dto
{
    public class EventBookerDto
    {
        [Required(ErrorMessage = "not information")]
        public int Id { get; set; }
        [Required(ErrorMessage = "not information")]
        [StringLength(maximumLength: 50,
                      MinimumLength = 2,
                      ErrorMessage = "Event Booker name's length must be between 2-50 characters")]
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public bool? Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }

        /*public virtual ICollection<ChatMessage> ChatMessage { get; set; }
        public virtual ICollection<EventOrder> EventOrder { get; set; }*/
    }
}
