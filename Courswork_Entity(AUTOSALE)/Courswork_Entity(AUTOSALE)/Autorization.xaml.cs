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
using System.Windows.Shapes;

namespace Courswork_Entity_AUTOSALE_
{
    /// <summary>
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void Click_Logo1(object sender, MouseButtonEventArgs e)
        {

        }

        private void Click_Avtoriz(object sender, RoutedEventArgs e)
        {
            Avtoriz.Content = new Page2();
        }
    }
}
