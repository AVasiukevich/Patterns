using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class B : IObserver<A>
    {
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(A a)
        {
            using (FileStream fs = new FileStream("text.txt", FileMode.Append, FileAccess.Write))
            {
                byte[] writeBytes = Encoding.UTF8.GetBytes(String.Format($"{a.Value} - {DateTime.Now}") + Environment.NewLine);
                fs.Write(writeBytes, 0, writeBytes.Length);
            }
        }
    }
}
