using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreningBoS.ViewModel.Components.MainPage
{
    public partial class KoloryContentViewModel : BaseViewModel
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(BoxViewColor))]
        double hue,saturation,luminosity;

        [ObservableProperty]
        bool isRendered;
        public Color BoxViewColor => Color.FromHsla(hue, saturation,luminosity);

        public KoloryContentViewModel()
        {

        }
    }
}
