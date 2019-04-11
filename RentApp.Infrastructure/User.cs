namespace RentApp.Infrastructure
{
    public class User : Person
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public bool IsActive { get; set; }
    }
}