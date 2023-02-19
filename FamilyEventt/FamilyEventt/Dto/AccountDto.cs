namespace FamilyEventt.Dto
{
    public class AccountDto
    {
        public int? Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AuthToken { get; set; }
        public string IdToken { get; set; }
        public string Role { get; set; }
        public int? Status { get; set; }
    }
}
