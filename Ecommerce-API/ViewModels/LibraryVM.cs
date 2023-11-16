namespace Ecommerce_API.ViewModels
{
    public class LibraryVM
    {
        public string Uid { get; set; } = null!;
        public string GameId { get; set; } = null!;
		public int? IsLike { get; set; }
		public string? FeedBack { get; set; }
    }
}
