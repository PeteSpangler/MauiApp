using CommunityToolkit.Maui.Core;

namespace NewApp.ViewModels;

public partial class DrawChoresViewModel : BaseViewModel
{
	[ObservableProperty]
	public ObservableCollection<IDrawingLine> lines = new();

	[RelayCommand]
	public void Clear()
	{
		Lines.Clear();
	}
}
