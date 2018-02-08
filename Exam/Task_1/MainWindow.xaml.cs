using System;
using System.Windows;
using Task_1Services;

namespace Task_1
{
    public partial class MainWindow : Window
    {
        private IFactoryServices _factory; 
        public MainWindow()
        {
            InitializeComponent();
            _factory = new FactoryServices();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var audio = _factory.CreateAudioService();
            _factory.CreateMessageBoxService().SearchErrors(() => audio.Load(tb_path.Text));
            if(audio.Info != null)
            {
                tbl_state.Text = String.Format($"Файл { audio.Info.Name} загружен!");
                btn_play.Visibility = Visibility.Visible;
                btn_save.Visibility = Visibility.Visible;
                tbl_save.Visibility = Visibility.Visible;
                tb_save.Visibility = Visibility.Visible;      
            }
            else
                tbl_state.Text = "Файл не загружен!";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _factory.CreateMessageBoxService().SearchErrors(_factory.CreateAudioService().Play);
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            _factory.CreateMessageBoxService().SearchErrors(() => _factory.CreateAudioService().Save(tb_save.Text));
        }
    }
}
