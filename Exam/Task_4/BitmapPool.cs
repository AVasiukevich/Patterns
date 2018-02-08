using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class BitmapPool
    {
        private int _maxSize;
        private IList<Bitmap> _listImage = new List<Bitmap>();
        private BitmapAdapter adapter;

        public BitmapPool(int maxSize)
        {
            _maxSize = maxSize;
        }
        public void AddPool(Bitmap image)
        {
            adapter = new BitmapAdapter(image);
            if (_listImage.Count - 3 < _maxSize)
            {
                _listImage.Add(adapter.GetNegative());
                _listImage.Add(adapter.TurnLeft());
                _listImage.Add(adapter.TurnRight());
            }
            else
                throw new IndexOutOfRangeException("Max pool!");
        }
        public Bitmap GetImages(int index)
        {
            if (index >= 0 && index < _listImage.Count)
                return _listImage[index];
            else
                return null;
        }
    }
}
