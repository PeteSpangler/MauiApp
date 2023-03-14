namespace NewApp.Views;

public partial class ChoreDetailsDetailPage : ContentPage
{
	public ChoreDetailsDetailPage(ChoreDetailsDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
