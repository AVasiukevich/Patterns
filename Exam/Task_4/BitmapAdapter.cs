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
            var tmp_image = new Bitmap(_image);
            Color c;
            for (int i = 0; i < tmp_image.Width; i++)
            {
                for (int j = 0; j < tmp_image.Height; j++)
                {
                    c = tmp_image.GetPixel(i, j);
                    c = Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);
                    tmp_image.SetPixel(i, j, c);
                }
            }
            return tmp_image;
        }

        public void Save(string path)
        {
            _image.Save(path);
        }

        public Bitmap TurnLeft()
        {
            var tmp_image = new Bitmap(_image);
            tmp_image.RotateFlip(RotateFlipType.Rotate90FlipXY);
            return tmp_image;
        }

        public Bitmap TurnRight()
        {
            var tmp_image = new Bitmap(_image);
            tmp_image.RotateFlip(RotateFlipType.Rotate270FlipXY);
            return tmp_image;
        }
    }
}
