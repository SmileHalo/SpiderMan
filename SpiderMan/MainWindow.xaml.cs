﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SpiderMan
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



        private void encode_Click_1(object sender, RoutedEventArgs e)
        {
            var t=HttpUtility.UrlEncode(UrlInput.Text, Encoding.UTF8);
            UrlOutput.Text = t;
        }

        private void decode_Click_2(object sender, RoutedEventArgs e)
        {
            var t = HttpUtility.UrlDecode(UrlInput.Text, Encoding.UTF8);
            UrlOutput.Text = t;
        }
    }
}
