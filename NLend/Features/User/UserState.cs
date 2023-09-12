using BlazorState;

namespace NLendApp.Features.User
{
	public partial class UserState : State<UserState>
	{
		public User? LoggedInUser { get; set; }

		public required List<User> Users { get; set; }
		public override void Initialize()
		{
			var zewa = new User() { Id = 1, Email = "zewa666@gmail.com", FirstName = "Vildan", LastName = "Softic" };
			var john = new User() { Id = 2, Email = "john@test.com", FirstName = "John", LastName = "Doe" };
			Users = new List<User>() { zewa, john };
			LoggedInUser = zewa;
		}

		public User? GetUserById(int? id)
		{
			if (!id.HasValue)
			{
				return null;
			}

			return Users.FirstOrDefault(u => u.Id == id);
		}
	}
}
