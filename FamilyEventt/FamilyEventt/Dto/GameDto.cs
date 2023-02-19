using FamilyEventt.Models;

namespace FamilyEventt.Dto
{
    public class GameDto
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Details { get; set; }
        public string Rules { get; set; }
        public string Reward { get; set; }
        public string Supplies { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }

        //public virtual ICollection<EntertainmentProduct> EntertainmentProduct { get; set; }
    }
}
