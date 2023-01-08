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
    /// Логика взаимодействия для Abonentsi.xaml
    /// </summary>
    public partial class Abonentsi : Page
    {
        public Abonentsi()
        {
            InitializeComponent();
            var data = Tarunov_peresdacha11Entities2.Getcontext().Abonenti_1.ToList();
            MyList.ItemsSource = data;
        }
    }
}
