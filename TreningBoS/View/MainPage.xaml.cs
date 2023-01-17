using TreningBoS.View.Components.MainPage;
using TreningBoS.ViewModel;
using TreningBoS.ViewModel.Components.MainPage;

namespace TreningBoS;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
    }
}

