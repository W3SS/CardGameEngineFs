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

namespace WPFLib
{
    /// <summary>
    /// Interaction logic for card.xaml
    /// </summary>
    public partial class card : UserControl
    {
        string fileName = "templ_1c.png";
        public card()
        {
            BitmapImage image = new BitmapImage(new Uri(@"\Assets\" + fileName, UriKind.RelativeOrAbsolute));
            IMG.Source = image;

            InitializeComponent();
        }
    }
}
