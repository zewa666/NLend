using BlazorState;
using MediatR;
using UserState = NLendApp.Features.User;

namespace NLendApp.Features.Shareables
{
	public partial class ShareablesState
	{
		public class BorrowItem : IAction
		{
			public required ShareableItem Item { get; set; }
			public required UserState.User By { get; set; }
		}

		public class BorrowItemHandler : ActionHandler<BorrowItem>
		{
			ShareablesState state => Store.GetState<ShareablesState>();
			public BorrowItemHandler(IStore aStore) : base(aStore)
			{
			}

			public override Task Handle(BorrowItem aAction, CancellationToken aCancellationToken)
			{
				var item = state.Items.FirstOrDefault(x => x.Id == aAction.Item.Id);
				if (item == null)
				{
					throw new ArgumentException("Could not find item to borrow");
				}

				item.LentBy = aAction.By.Id;
				item.LentOn = DateTimeOffset.UtcNow;

				return Unit.Task;
			}
		}
	}
}
