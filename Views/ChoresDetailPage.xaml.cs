namespace NewApp.Views;

public partial class ChoresDetailPage : ContentPage
{
	public ChoresDetailPage(ChoresDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
