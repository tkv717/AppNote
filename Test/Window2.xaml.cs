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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        MainWindow MainWindow = new MainWindow();
        public Window2()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.q2 = 1;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            MainWindow.q2 = 0;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            MainWindow.q2 = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
            MainWindow.i = +MainWindow.q2;
            Close();
        }
    }
}
