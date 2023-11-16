namespace Ecommerce_API.ViewModels
{
    public class ClientVM
    {
        
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string PassWord { get; set; } = null!;
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? IsActive { get; set; }
        public DateTime? DayOfBirth { get; set; }
    }
}
