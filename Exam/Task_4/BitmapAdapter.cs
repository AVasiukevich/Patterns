using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class BitmapAdapter : IBitmapAdapter
    {
        private Bitmap _image;

        public BitmapAdapter(Bitmap image)
        {
            _image = image;
        }
        public Bitmap Image
        {
            get { return _image; }
        }
        public Bitmap GetNegative()
        {
            Color c;
            for (int i = 0; i < _image.Width; i++)
            {
                for (int j = 0; j < _image.Height; j++)
                {
                    c = _image.GetPixel(i, j);
                    c = Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);
                    _image.SetPixel(i, j, c);
                }
            }
            return _image;
        }

        public void Save(string path)
        {
            _image.Save(path);
        }

        public Bitmap TurnLeft()
        {
            _image.RotateFlip(RotateFlipType.Rotate90FlipXY);
            return _image;
        }

        public Bitmap TurnRight()
        {
            _image.RotateFlip(RotateFlipType.Rotate270FlipXY);
            return _image;
        }
    }
}
