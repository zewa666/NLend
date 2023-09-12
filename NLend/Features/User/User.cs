namespace NLendApp.Features.User
{
	public class User
	{
		public int Id { get; set; }
		public required string FirstName { get; set; }
		public required string LastName { get; set; }
		public required string Email { get; set; }

		public string FullName
		{
			get
			{
				return FirstName + " " + LastName;
			}
		}
	}
}
