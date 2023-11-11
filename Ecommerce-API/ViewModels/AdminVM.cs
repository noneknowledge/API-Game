namespace Ecommerce_API.ViewModels
{
    public class AdminVM
    {
        public string AdminId { get; set; } = null!;
        public string? AdName { get; set; }
        public string? PassWord { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? IsActive { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
