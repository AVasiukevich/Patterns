using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var chatroom = new ChatRoom();
            var ivan = new User(chatroom, "Ivan");
            var lena = new User(chatroom, "Lena");
            var jan = new User(chatroom, "Jan");
            var john = new User(chatroom, "John");

            ivan.Send("Встречаемся в среду на экзамене, ок?");
            lena.Send("Ok");
            ivan.Send("Ян?");
            jan.Send("Ok ok");
            ivan.Send("Договорились.");

            var personal_1 = new ChatRoom();
            ivan.CreatePersonalChat(personal_1, lena);
            ivan.SendPersonalChat("Привет!", personal_1);

            var group_1 = new ChatRoom();
            ivan.CreatePersonalChat(group_1, jan, john);
            ivan.SendPersonalChat("Привет народ!", group_1);

            Console.ReadLine();
        }
        public static void Logging(string message)
        {
            File.AppendAllText("logs.txt", message);
        }
    }
}
