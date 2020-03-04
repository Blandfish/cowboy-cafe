﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// event listeners for buttons on order control
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
            Order CurrentOrder = new Order();
            DataContext = CurrentOrder;

           
        }
        // may need to be disabled
        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }


        
    }
}
