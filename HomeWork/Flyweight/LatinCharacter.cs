using System;
using System.Windows.Media.Imaging;

namespace Flyweight
{
    class LatinCharacter : Character
    {
        public char Symbol { get; set; }
        public BitmapImage picture { get; set; } 

        public override void Display(int position)
        {
            Console.WriteLine("{0} (Position is {1}", Symbol, position);
        }
    }
}
