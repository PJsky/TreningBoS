using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreningBoS.Factories.ElementFactories;
using TreningBoS.Model;

namespace TreningBoS.Services
{
    public class ElementService : IElementService
    {
        public IElementFactory ElementFactory { get; }
        public ElementService(IElementFactory elementFactory)
        {
            ElementFactory = elementFactory;
        }
        public List<ElementModel> GetElements() => ElementFactory.GetElements();
    }
}
