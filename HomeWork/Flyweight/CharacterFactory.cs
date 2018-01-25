using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Flyweight
{
    public class CharacterFactory
    {
        private readonly Dictionary<char, Character> _chars = new Dictionary<char, Character>();

        public Character GetCharacter(char key, BitmapImage image = null)
        {
            if (!_chars.ContainsKey(key))
            {
                if (key == ' ')
                {
                    _chars.Add(key, new Whitespace());
                }
                else
                {
                    _chars.Add(key, new LatinCharacter { Symbol = key, picture = image });
                }
            }
            return _chars[key];
        }
        public int Count()
        {
            return _chars.Count;
        }
    }
}
