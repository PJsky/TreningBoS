using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreningBoS.View.Components.MainPage;
using TreningBoS.ViewModel.Components.MainPage;

namespace TreningBoS.ViewModel
{
    public partial class MainViewModel : BaseViewModel
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsListaContentViewRendered))]
        [NotifyPropertyChangedFor(nameof(IsKoloryContentViewRendered))]
        string rightSideComponentName;
        public ListaContentViewModel ListaContentViewModel { get; set; }
        public KoloryContentViewModel KoloryContentViewModel { get; set; }
        public bool IsListaContentViewRendered => RightSideComponentName == nameof(ListaContentView);
        public bool IsKoloryContentViewRendered => RightSideComponentName == nameof(KoloryContentView);

        public MainViewModel(ListaContentViewModel listaContentViewModel, KoloryContentViewModel koloryContentViewModel)
        {
            Title = "Trening".ToUpper();
            ListaContentViewModel = listaContentViewModel;
            KoloryContentViewModel = koloryContentViewModel;
        }

        [RelayCommand]
        void GetLista()
        {
            RightSideComponentName = nameof(ListaContentView);
            ListaContentViewModel.ListRendered = IsListaContentViewRendered;
            KoloryContentViewModel.IsRendered = IsKoloryContentViewRendered;
        }

        [RelayCommand]
        void GetKolory()
        {
            RightSideComponentName = nameof(KoloryContentView);
            ListaContentViewModel.ListRendered = IsListaContentViewRendered;
            KoloryContentViewModel.IsRendered = IsKoloryContentViewRendered;
        }
    }
}
