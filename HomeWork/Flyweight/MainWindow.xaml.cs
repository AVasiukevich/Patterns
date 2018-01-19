using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Flyweight
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CharacterFactory factory = new CharacterFactory();
        public MainWindow()
        {
            InitializeComponent();
            factory.GetCharacter('A', new BitmapImage(new Uri("alpha.png", UriKind.Relative)));
            factory.GetCharacter('B', new BitmapImage(new Uri("beta.png", UriKind.Relative)));
            factory.GetCharacter('H', new BitmapImage(new Uri("eta.png", UriKind.Relative)));
            factory.GetCharacter('K', new BitmapImage(new Uri("kappa.png", UriKind.Relative)));
            factory.GetCharacter('O', new BitmapImage(new Uri("omicron.png", UriKind.Relative)));
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            uniform.Children.Clear();
            uniform.Columns = tb_main.Text.Length;
            var _chars = tb_main.Text.ToCharArray();
            for (int i = 0; i < tb_main.Text.Length; i++)
                    uniform.Children.Add(new Image() { Source = ((LatinCharacter)factory.GetCharacter(_chars[i])).picture});
            tbl.Text = String.Format($"Размер словаря: {factory.Count()}. ABHKO внесены с image!");           
        }
    }
}
