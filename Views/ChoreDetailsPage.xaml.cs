namespace NewApp.Views;

public partial class ChoreDetailsPage : ContentPage
{
	ChoreDetailsViewModel ViewModel;

	public ChoreDetailsPage(ChoreDetailsViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = ViewModel = viewModel;
	}

	protected override async void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);

		await ViewModel.LoadDataAsync();
	}
}
