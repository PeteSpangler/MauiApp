namespace NewApp.Views;

public partial class ChoresPage : ContentPage
{
	ChoresViewModel ViewModel;

	public ChoresPage(ChoresViewModel viewModel)
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
