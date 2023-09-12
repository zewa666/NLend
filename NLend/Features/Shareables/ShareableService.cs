using MediatR;

namespace NLendApp.Features.Shareables
{
	public interface IShareableService
	{
		void BorrowItem(ShareableItem item, User.User borrower);
		Task LoadDbData();
	}

	public class ShareableService : IShareableService
	{
		private IMediator Mediator { get; set; }

		public ShareableService(IMediator mediator)
		{
			Mediator = mediator;
		}

		public async Task LoadDbData()
		{
			await Mediator.Send(new ShareablesState.FetchItems());
		}

		public async void BorrowItem(ShareableItem item, User.User borrower)
		{
			if (borrower == null)
			{
				return;
			}

			await Mediator.Send(new ShareablesState.BorrowItem() { Item = item, By = borrower });
		}
	}
}
