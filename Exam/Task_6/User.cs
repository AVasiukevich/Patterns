using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class User
    {
        private readonly ChatRoom _chatRoom;
        private readonly string _name;

        public User(ChatRoom chatRoom, string name)
        {
            _chatRoom = chatRoom;
            _name = name;
            _chatRoom.SignOn(this);
        }

        public virtual void RecieveMessage(string message, string from)
        {
            if (_name != from)
            {
                Console.WriteLine("{0} recieved a message from {1}: {2}", _name, from, message);
                Program.Logging(String.Format("{0} recieved a message from {1}: {2}", _name, from, message) + Environment.NewLine);
            }
        }

        public void Send(string message)
        {
            Console.WriteLine("Sent from {0}: {1}", _name, message);
            Program.Logging(String.Format($"Sent from {_name}: {message}") + Environment.NewLine);
            _chatRoom.Send(message, _name);
        }

        public void CreatePersonalChat(ChatRoom room, params User[] otherUsers)
        {
            foreach (var item in otherUsers)
            {
                room.SignOn(item);
            }
        }
        public void SendPersonalChat(string message, ChatRoom room)
        {
            Console.WriteLine("\t(Personal)Sent from {0}: {1}", _name, message);
            Program.Logging(String.Format($"(Personal)Sent from {_name}: {message}") + Environment.NewLine);
            room.Send("\t(Personal)" + message, _name);
        }
    }
}
