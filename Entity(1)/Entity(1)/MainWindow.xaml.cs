﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Entity_1_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SilpoEntities db = null;
        public MainWindow()
        {
            InitializeComponent();
            db = new SilpoEntities();
            List.ItemsSource = db.Products.ToList();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            Add DI = new Add();
            DI.ShowDialog();
            if(DI.DialogResult==true)

            {
                List.ItemsSource = db.Products.ToList();
            }
        }
    }
}
