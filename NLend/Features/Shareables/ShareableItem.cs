namespace NLendApp.Features.Shareables
{
	public class ShareableItem
	{
		public int Id { get; set; }
		public string? Image { get; set; }
		public required string Name { get; set; }
		public required string Description { get; set; }
		public int OwnerId { get; set; }
		public int? LentBy { get; set; }
		public DateTimeOffset? LentOn { get; set; }
	}
}