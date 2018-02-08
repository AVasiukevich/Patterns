using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var page = new HtmlPage() { Name = "Main"};
            var section = new HtnlSection() { Name = "ur", Info = "<h1>Список:</h1>"};
            section.AddElement(new HtmlElement() { Name="Страница 1", Info = "<img>Картинка №1</img>"});
            section.AddElement(new HtmlElement() { Name = "Страница 2", Info = "<img>Картинка №2</img>" });
            section.AddElement(new HtmlElement() { Name = "Страница 3", Info = "<img>Картинка №3</img>" });
            page.AddElement(section);
            Console.WriteLine(page.Print());
            Console.ReadLine();
        }
    }
}
