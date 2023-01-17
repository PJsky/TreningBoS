using CommunityToolkit.Mvvm.ComponentModel;

namespace TreningBoS.ViewModel
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        string title;
    }
}
