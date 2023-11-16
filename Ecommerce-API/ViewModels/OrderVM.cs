namespace Ecommerce_API.ViewModels
{
	public class OrderVM
	{
		public string Uid { get; set; } = null!;
		
		public string? PaymentId { get; set; }
		public int? Amount { get; set; }
		public string? DiscountId { get; set; }
		public int? Total { get; set; }
	}
}
