using System;

namespace Flyweight
{
    class Whitespace : Character
    {
        public override void Display(int position)
        {
            Console.WriteLine("_ (position is {0}", position);
        }
    }
}
