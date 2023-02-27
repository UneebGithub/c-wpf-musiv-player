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

namespace cal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            
        }

        private void button_clicl_Click1(object sender, RoutedEventArgs e)
            
        {
            login log = new login();
            if (pass.Password == log.password && user.Text == log.username)
            {
                mainpl v = new mainpl();
                this.Close();
                v.Show();
            }
            else
            {
                MessageBox.Show("UserName Or Password Is Wrong ");
            }
            
        }
    }
}
