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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        MainWindow MainWindow = new MainWindow();
        public Window1()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.q1 = 1;
            MessageBox.Show(""+MainWindow.q1);
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            MainWindow.q1 = 0;
            MessageBox.Show("" + MainWindow.q1);
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            MainWindow.q1 = 0;
            MessageBox.Show("" + MainWindow.q1);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window6 window6 = new Window6();
            window6.Show();
            MainWindow.i = +MainWindow.q1;
        }
    }
}
