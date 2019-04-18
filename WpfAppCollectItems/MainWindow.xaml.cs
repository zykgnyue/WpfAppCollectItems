﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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

namespace WpfAppCollectItems
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAddPerson_Click(object sender, RoutedEventArgs e)
        {
            //Add(new PersonName("Willa", "Cather"));
            if (this.Resources["NameListData"] is NameList xx)
            {
                xx.Add(new PersonName($"Willa{xx.Count.ToString("000")}", $"Cather{xx.Count.ToString("000")}"));
            }
        }
    }
}
