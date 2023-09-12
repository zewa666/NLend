using BlazorState;

namespace NLendApp.Features.Shareables
{
	public partial class ShareablesState : State<ShareablesState>
	{
		public ShareableItem[] Items { get; set; } = new ShareableItem[0];
        public override void Initialize() => Items = new ShareableItem[0];
	}
}
