﻿using System;
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
    /// Логика взаимодействия для Avtorizacia.xaml
    /// </summary>
    public partial class Avtorizacia : Page
    {
        public Avtorizacia()
        {
            InitializeComponent();
        }


        private void Vhod_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainWindowFrame.Content = new Home();
        }
    }
}
