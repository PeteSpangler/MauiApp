namespace NewApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(ChoresDetailPage), typeof(ChoresDetailPage));
		Routing.RegisterRoute(nameof(ChoreDetailsDetailPage), typeof(ChoreDetailsDetailPage));
	}
}
