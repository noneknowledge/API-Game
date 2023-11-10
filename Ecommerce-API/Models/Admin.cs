using System;
using System.Collections.Generic;

namespace Ecommerce_API.Models
{
    public partial class Admin
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
