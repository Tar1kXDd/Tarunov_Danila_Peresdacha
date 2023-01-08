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

namespace Tarunov_Danila_Peresdacha
{
    /// <summary>
    /// Логика взаимодействия для Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
            var data = Tarunov_peresdacha11Entities2.Getcontext().Info_sotrudniki.ToList();
            MyList.ItemsSource = data;

        }

        private void Sotrudniki(object sender, RoutedEventArgs e)
        {
            MainWindow.MainWindowFrame.Content = new Pages.Sotrudniki();
        }

        private void Abonents(object sender, RoutedEventArgs e)
        {

            MainWindow.MainWindowFrame.Content = new Pages.Abonentsi();
        }

        private void Oborudovanie(object sender, RoutedEventArgs e)
        {
            MainWindow.MainWindowFrame.Content = new Pages.Oborudovanies();
        }
    }
}
