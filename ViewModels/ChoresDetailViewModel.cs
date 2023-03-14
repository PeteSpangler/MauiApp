namespace NewApp.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class ChoresDetailViewModel : BaseViewModel
{
	[ObservableProperty]
	SampleItem item;
}
