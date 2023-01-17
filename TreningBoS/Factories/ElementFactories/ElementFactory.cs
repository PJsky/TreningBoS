using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreningBoS.Model;

namespace TreningBoS.Factories.ElementFactories
{
    public class ElementFactory : IElementFactory
    {
        public List<ElementModel> GetElements()
        {
            var elements = new List<ElementModel>();
            for (int i = 0; i < 10; i++)
                elements.Add(new ElementModel()
                {
                    ElementName = i.ToString(),
                    Description = i.ToString() + i.ToString(),
                });
            return elements;
        }
    }
}
