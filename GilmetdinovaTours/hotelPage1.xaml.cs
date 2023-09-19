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

namespace GilmetdinovaTours
{
    /// <summary>
    /// Логика взаимодействия для hotelPage1.xaml
    /// </summary>
    public partial class hotelPage1 : Page
    {
        public hotelPage1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            manager.MainFrame.Navigate(new addPage1());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
