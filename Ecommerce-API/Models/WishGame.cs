namespace Ecommerce_API.Models
{
    public class WishGame
    {
        public string UID { get; set; } = null!;
        public string GameId { get; set; } = null!;
        public virtual Game Game { get; set; } = null!;
        public virtual Client UidNavigation { get; set; } = null!;
    }
}
