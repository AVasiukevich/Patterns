using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class ChatRoom
    {
        private readonly ISet<User> _colleagues = new HashSet<User>();

        public void SignOn(User participant)
        {
            _colleagues.Add(participant);
        }

        public void Send(string message, string from)
        {
            foreach (var colleague in _colleagues)
            {
                colleague.RecieveMessage(message, from);
            }
        }
    }
}
