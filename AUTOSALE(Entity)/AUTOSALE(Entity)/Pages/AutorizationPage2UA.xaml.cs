﻿using AUTOSALE_Entity_.ViewModel;
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

namespace AUTOSALE_Entity_.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutorizationPage2UA.xaml
    /// </summary>
    public partial class AutorizationPage2UA : Page
    {
        MainViewModel MvM;
        public AutorizationPage2UA(MainViewModel mvm)
        {
            InitializeComponent();
            MvM = mvm;
        }
    }
}
