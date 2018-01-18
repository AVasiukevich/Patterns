using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite
{
    class Document : IXmlElements
    {
        private List<IXmlElements> _list = new List<IXmlElements>();
        public string Name { get; set; }
        public string Value { get; set; }

        public void AddElement(IXmlElements element)
        {
            _list.Add(element);
        }

        public XElement CreateElement()
        {
            var elements = new XElement(Name, Value);
            foreach (var item in _list)
            {
                elements.Add(item.CreateElement());
            }
            return elements;
        }

        public void ShowElement()
        {
            Console.WriteLine($"<{Name}> {Value}");
            foreach (var item in _list)
            {
                item.ShowElement();
            }
            Console.WriteLine($"</{Name}>");
        }
        public void SaveXML(string path)
        {
            CreateElement().Save(path);
        }
    }
}
