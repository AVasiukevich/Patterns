using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class HtmlPage : IHtmlElement
    {
        private IList<IHtmlElement> _sections = new List<IHtmlElement>();
        public string Info { get; set; }
        public string Name { get; set; }

        public void AddElement(IHtmlElement element)
        {
            _sections.Add(element);
        }

        public string Print()
        {
            var str = new StringBuilder($"<html>\n<head>\n\t<title>{Name}</title>\n</head>\n<body>\n");
            foreach (var item in _sections)
            {
                str.Append($"{item.Print()}\n");
            }
            return str.Append($"</body>\n</html>").ToString();
        }
    }
}
