using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new Document() { Name="First"};
            var element = new SingleElement() { Name = "Sub_1", Value = "Sub" };
            var document_2 = new Document() { Name = "Second" };
            var element_2 = new SingleElement() { Name = "Sub_2", Value = "Sub" };
            document_2.AddElement(element_2);
            document.AddElement(element);
            document.AddElement(document_2);
            document.ShowElement();

            document.SaveXML("text.xml");
            Console.ReadLine();
        }
    }
}
