using System;
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

            NewOrderButton.Click += NewOrderButtonClicked;
            CancelOrderButton.Click += NewOrderButtonClicked;
        }

        // may need to be disabled
        /// <summary>
        /// method to swap the control from menuItemSelection Control to a control to configure the order item
        /// </summary>
        /// <param name="element"></param>
        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }


        /// <summary>
        /// event handler for new order creates a new order and sets the datacontext to it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        public void NewOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            Order CurrentOrder = new Order();
            DataContext = CurrentOrder;

        }
        /// <summary>
        /// event handler for new order creates a new order and sets the datacontext to it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CancelOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            Order CurrentOrder = new Order();
            DataContext = CurrentOrder;

        }


    }
}
