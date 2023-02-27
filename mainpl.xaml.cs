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
using System.Windows.Shapes;

namespace cal
{
    /// <summary>
    /// Interaction logic for mainpl.xaml
    /// </summary>
    public partial class mainpl : Window
    {
        public mainpl()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        private void song1(Object sender, RoutedEventArgs e)
        {
            play_song0.Play();
        }
        private void song2(Object sender, RoutedEventArgs e)
        {
            play_song2.Play();
        }
        private void song3(Object sender, RoutedEventArgs e)
        {
            play_song3.Play();
        }
        private void back(Object sender, RoutedEventArgs e)
        {
            mainpl reply_video_screen = new mainpl();
            this.Close();
            reply_video_screen.Show();
        }
        public void log(Object sender, RoutedEventArgs e)
        {
            MainWindow login_main = new MainWindow();
            this.Close();
            login_main.Show();
        }
    }
}
