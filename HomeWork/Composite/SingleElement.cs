using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite
{
    class SingleElement : IXmlElements
    {
        public string Name { get; set; }

        public string Value { get; set; }

        public XElement CreateElement()
        {
            return new XElement( Name, Value);
        }

        public void ShowElement()
        {
            Console.WriteLine(CreateElement().ToString());
        }
    }
}
