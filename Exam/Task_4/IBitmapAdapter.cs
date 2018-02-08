using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public interface IBitmapAdapter
    {
        Bitmap GetNegative();
        Bitmap TurnLeft();
        Bitmap TurnRight();
        void Save(string path);
    }
}
