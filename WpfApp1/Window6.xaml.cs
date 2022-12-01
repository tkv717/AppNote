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
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        MainWindow MainWindow = new MainWindow();
        public Window6()
        {
            InitializeComponent();
            MainWindow.i = MainWindow.q1+MainWindow.q2 + MainWindow.q3+MainWindow.q4+MainWindow.q5;
            MessageBox.Show("Вы" + MainWindow.i);
        }
    }
}
