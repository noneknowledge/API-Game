namespace Ecommerce_API.ViewModels
{
	public class GameVM
	{
		public string? GameName { get; set; }
		public string? GameDes { get; set; }
		public int? Price { get; set; }
		public IFormFile ThumbnailIMG { get; set; }
		public string? Video { get; set; }
		public string? DevId { get; set; }
		public string? PublisherId { get; set; }
		public DateTime? ReleaseDate { get; set; }	
		public List<IFormFile> ImageFiles { get; set; }
		public List<string> CateIds { get; set; }
	}
}
