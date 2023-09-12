using BlazorState;

namespace NLendApp.Features.Shareables
{
	public partial class ShareablesState
	{
		public class FetchItems : IAction { }
		public class FetchItemsHandler : ActionHandler<FetchItems>
		{
			ShareablesState state => Store.GetState<ShareablesState>();
			public FetchItemsHandler(IStore aStore) : base(aStore)
			{
			}

			public override async Task Handle(FetchItems aAction, CancellationToken aCancellationToken)
			{
				state.Items = new ShareableItem[]
				{
					new ShareableItem()
					{
						Id = 1,
						Name = "Einhell Rasentrimmer",
						Description = "Trimmer von Einhell mit Power-X-Change Akku",
						OwnerId = 1,
						Image = "https://m.media-amazon.com/images/I/51E3WZa1iGL._AC_SL1417_.jpg"
					},
					new ShareableItem()
					{
						Id = 2,
						Name = "Einhell Rasenmäher",
						Description = "Rasenmäher von Einhell mit Power-X-Change Akku",
						OwnerId = 1,
						Image = "https://m.media-amazon.com/images/I/71kkpe71wtL._AC_SL1500_.jpg"
					},
					new ShareableItem()
					{
						Id = 3,
						Name = "Vorschlaghammer",
						Description = "Groß, schwer und macht aua",
						OwnerId = 1,
						LentBy = 2,
						LentOn = DateTimeOffset.UtcNow.AddDays(-6),
						Image = "https://images.obi.at/product/CZ/415x415/150025_1.jpg"
					},
					new ShareableItem()
					{
						Id = 4,
						Name = "Makita Akkubohrer",
						Description = "Ein Akkubohrer von Makita",
						OwnerId = 2,
						Image = "https://m.media-amazon.com/images/I/81IfTtIsmIL._AC_SL1500_.jpg"
					}
				};
			}
		}
	}
}
