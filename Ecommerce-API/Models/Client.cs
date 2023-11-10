using System;
using System.Collections.Generic;

namespace Ecommerce_API.Models
{
    public partial class Client
    {
        public Client()
        {
            Libraries = new HashSet<Library>();
            Orders = new HashSet<Order>();
            Games = new HashSet<Game>();
            GamesNavigation = new HashSet<Game>();
        }

        public string Uid { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string PassWord { get; set; } = null!;
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Image { get; set; }
        public int? Balance { get; set; }
        public string? IsActive { get; set; }
        public DateTime? DayOfBirth { get; set; }

        public virtual ICollection<Library> Libraries { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<WishGame> WishLists { get; set; }
        public virtual ICollection<Game> Games { get; set; }
        public virtual ICollection<Game> GamesNavigation { get; set; }
    }
}
