using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreningBoS.ViewModel
{
    //TODO: may implement interface for viewModel -> will have to change registration
    public interface IMainViewModel
    {
        Task GetListaAsync();
        Task GetKoloryAsync();
    }
}
