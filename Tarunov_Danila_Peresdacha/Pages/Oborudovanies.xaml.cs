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

namespace Tarunov_Danila_Peresdacha.Pages
{
    /// <summary>
    /// Логика взаимодействия для Oborudovanies.xaml
    /// </summary>
    public partial class Oborudovanies : Page
    {
        public Oborudovanies()
        {
            InitializeComponent();
            var data = Tarunov_peresdacha11Entities2.Getcontext().Oborudovanie.ToList();
            MyList.ItemsSource = data;
        }
    }
}
