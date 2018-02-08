using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class HtnlSection : IHtmlElement
    {
        private IList<IHtmlElement> _elements = new List<IHtmlElement>();
        public string Info { get; set; }
        public string Name { get; set; }

        public void AddElement(IHtmlElement element)
        {
            _elements.Add(element);
        }

        public string Print()
        {
            var str = new StringBuilder($"<html>\n<head>\n\t<title>{Name}</title>\n</head>\n<body>\n\t{Info}\n");
            foreach (var item in _elements)
            {
                str.Append($"{item.Print()}\n");
            }
            return str.Append($"</body>\n</html>").ToString();
        }
    }
}
