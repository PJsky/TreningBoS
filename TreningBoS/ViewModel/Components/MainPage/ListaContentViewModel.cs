using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using TreningBoS.Model;
using TreningBoS.Services;

namespace TreningBoS.ViewModel.Components.MainPage
{
    public partial class ListaContentViewModel : BaseViewModel
    {
        public ObservableCollection<ElementModel> Elements { get; } = new();
        [ObservableProperty]
        bool listRendered;
        public IElementService ElementService { get; set; }
        public ListaContentViewModel()
        {
            ListRendered = false;
        }
        public ListaContentViewModel(IElementService elementService)
        {
            ElementService = elementService;
        }

        [RelayCommand]
        void InitializeElements()
        {
            var elements = ElementService.GetElements();

            if (elements.Any()) Elements.Clear();

            foreach (var element in elements)
                Elements.Add(element);
        }
    }
}
