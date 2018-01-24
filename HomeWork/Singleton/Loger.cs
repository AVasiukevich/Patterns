using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Loger
    {
        private static readonly Lazy<Loger> _lazy = new Lazy<Loger>(() => new Loger());
        public string Path { get; }

        private Loger()
        {
            Console.Write("Введите путь к файлу: ");
            Path = Console.ReadLine();
        }
        public static Loger GetInstance()
        {
            return _lazy.Value;
        }
        public void WriteInFile()
        {
            using (var stream = new FileStream(Path, FileMode.OpenOrCreate))
            {
                Console.Write("Введите текст для записи: ");
                var text = Console.ReadLine();
                byte[] writeBytes = Encoding.UTF8.GetBytes(text);
                stream.Write(writeBytes, 0, writeBytes.Length);
            }
        }
    }
}
