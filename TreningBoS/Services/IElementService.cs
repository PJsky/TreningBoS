using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreningBoS.Model;

namespace TreningBoS.Services
{
    public interface IElementService
    {
        List<ElementModel> GetElements();
    }
}
