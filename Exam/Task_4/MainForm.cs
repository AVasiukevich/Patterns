using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4
{
    public partial class MainForm : Form
    {
        //private BitmapPool _images;
        private BitmapAdapter a;
        private IList<Bitmap> _listImage = new List<Bitmap>();
        public MainForm()
        {
            InitializeComponent();
            //_images = new BitmapPool(3);
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog();

            openFile.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //_images.AddPool(new Bitmap(openFile.FileName));
                a = new BitmapAdapter(new Bitmap(openFile.FileName));
                pct_main.Image = a.Image;
            }
            _listImage.Add(a.TurnLeft());
            //_listImage.Add(a.GetNegative());
            _listImage.Add(a.TurnRight());
        }

        private void btn_negative_Click(object sender, EventArgs e)
        {   
            pct_main.Image = a.TurnLeft();
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            pct_main.Image = _listImage[1];
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            pct_main.Image = _listImage[2];
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
               pct_main.Image.Save(saveFile.FileName);
            }
        }
    }
}
