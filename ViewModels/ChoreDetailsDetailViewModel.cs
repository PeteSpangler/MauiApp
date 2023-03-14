namespace NewApp.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class ChoreDetailsDetailViewModel : BaseViewModel
{
	[ObservableProperty]
	SampleItem item;
}
