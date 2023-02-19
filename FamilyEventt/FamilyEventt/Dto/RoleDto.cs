using FamilyEventt.Models;

namespace FamilyEventt.Dto
{
    public class RoleDto
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

       // public virtual ICollection<Staff> Staff { get; set; }
    }
}
