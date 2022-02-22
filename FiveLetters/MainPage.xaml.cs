using FiveLetters.ViewModel;

namespace FiveLetters;

public partial class MainPage : ContentPage
{

	public MainPage(GameViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
		var frame = new Frame();
	}
}

