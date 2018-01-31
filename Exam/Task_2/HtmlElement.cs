using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class HtmlElement : IHtmlElement
    {
        public string Info { get; set; }
        public string Name { get; set; }

        public string Print()
        {
            return String.Format($"<html>\n<head>\n\t<title>{Name}</title>\n</head>\n<body>\n\t{Info}\n</body>\n</html>");
        }
    }
}
