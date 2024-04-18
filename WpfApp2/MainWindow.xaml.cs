using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace messagebox
{
    /// <summary> 
    /// Логика взаимодействия для MainWindow.xaml 
    /// </summary> 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            string messageboxtext = "Ты нажал на меня?\nЕсли да то нажми на OK";
            string caption = ";0";
            MessageBoxButton btn = MessageBoxButton.OKCancel;     
            MessageBoxResult res;
            res = MessageBox.Show(messageboxtext, caption, btn);

            if (res == MessageBoxResult.OK)
            {
                Image img = new Image();
                img.Source = new BitmapImage(new Uri("C:\\Users\\Дилюк\\Downloads\\3azICzs6aWo.jpg", UriKind.RelativeOrAbsolute));
                img.Width = 1024;
                img.Height = 800;

                Window window = new Window();
                window.Title = "Image";
                window.Content = img;
                window.ShowDialog();
            }
            else if (res == MessageBoxResult.Cancel)
            {
                messageboxtext = "<====8";
                caption = "<====8";
                MessageBoxButton button = MessageBoxButton.YesNo;
                MessageBoxResult resik;
                resik=MessageBox.Show(messageboxtext, caption, button);
            }
        }

        private void bnt1_Click(object sender, RoutedEventArgs e)
        {
            string messageboxtext = "Ginnera ответ!";
            string caption = "<====8";
            MessageBoxButton btn = MessageBoxButton.YesNo;
            MessageBoxResult res;
            res=MessageBox.Show(messageboxtext, caption,btn);

        }
        
    }
}