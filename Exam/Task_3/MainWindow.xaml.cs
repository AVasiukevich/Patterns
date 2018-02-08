using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        private LineSegmentFactory _factory;
        public MainWindow()
        {
            InitializeComponent();
            _factory = new LineSegmentFactory();
        }

        private void can_main_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (can_main.Children.Count > 0 && can_main.Children[can_main.Children.Count - 1] != null)
                can_main.Children.Add(_factory.GetLine(new double[] { Canvas.GetLeft(can_main.Children[can_main.Children.Count - 1]),
                    e.GetPosition(can_main).X,
                    Canvas.GetTop(can_main.Children[can_main.Children.Count - 1]),
                    e.GetPosition(can_main).Y }));
            
            var ellipse = new Ellipse() { Width = 3, Height = 3, Fill = Brushes.Black};

            can_main.Children.Add(ellipse);
            Canvas.SetTop(ellipse, e.GetPosition(can_main).Y);
            Canvas.SetLeft(ellipse, e.GetPosition(can_main).X);

            tbl_pos_x.Text = String.Format($"X: {e.GetPosition(can_main).X}");
            tbl_pos_y.Text = String.Format($"Y: {e.GetPosition(can_main).Y}");
        }
    }
}
