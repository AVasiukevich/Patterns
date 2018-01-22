using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite
{
    interface IXmlElements
    {
        string Name { get; set; }
        string Value { get; set; }
        XElement CreateElement();
        void ShowElement();
    }
}
