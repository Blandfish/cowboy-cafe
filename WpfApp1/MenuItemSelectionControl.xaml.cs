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
using System.Windows.Shapes;
using CowboyCafe.Data;
using CowboyCafe.Extensions;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        private OrderControl orderControl;

        public MenuItemSelectionControl()
        {
            InitializeComponent();

            

            AddCowpokeChiliButton.Click += OnItemAddButtonClicked; // changed may need to revert for milestone2

            /* AddCowpokeChiliButton.Click += OnAddCowpokeChiliButtonClicked;
             * AddAngryChickenButton.Click += OnAddAngryChickenButtonClicked;
             AddBakedBeansButton.Click += OnAddBakedBeansButtonClicked;
             AddCornDodgersButton.Click += OnAddCornDodgersButtonClicked;
             AddDakotaDoubleBurgerButton.Click += OnAddDakotaDoubleBurgerButtonClicked;
             AddPanDeCampoButton.Click += OnAddPanDeCampoButtonClicked;
             AddPecosPulledPorkButton.Click += OnAddPecosPulledPorkButtonClicked;
             AddRustlersRibsButton.Click += OnAddRustlersRibsButtonClicked;
             AddTexasTripleBurgerButton.Click += OnAddTexasTripleBurgerButtonClicked;
             AddTrailBurgerButton.Click += OnAddTrailBurgerButtonClicked;
             AddChiliCheeseFriesButton.Click += OnAddChiliCheeseFriesButtonClicked;

             AddTexasTeaButton.Click += OnAddTexasTeaButtonClicked;
             AddWaterButton.Click += OnAddWaterButtonClicked;
             AddJerkedSodaButton.Click += OnAddJerkedSodaButtonClicked;
             AddCowboyCoffeeButton.Click += OnAddCowboyCoffeeButtonClicked;
              */

        }

        /* alternative to hold everything in one method with parts from */
        public void OnItemAddButtonClicked(object sender,RoutedEventArgs e)
        {
            orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch(button.Tag)
                    {
                        case "CowpokeChili":

                            order.Add(new CowpokeChili());
                            orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                    }
                }
            }
        }
        


        /*void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {

            ((Order)DataContext).Add(new CowpokeChili());

        }        /*
        void OnAddAngryChickenButtonClicked(Object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new AngryChicken());
        }

        void OnAddBakedBeansButtonClicked(Object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new BakedBeans());
        }

        void OnAddChiliCheeseFriesButtonClicked(Object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new ChiliCheeseFries());
        }

        void OnAddCornDodgersButtonClicked(Object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CornDodgers());
        }

        void OnAddDakotaDoubleBurgerButtonClicked(Object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new DakotaDoubleBurger());
        }

        void OnAddJerkedSodaButtonClicked(Object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new JerkedSoda());
        }

        void OnAddPanDeCampoButtonClicked(Object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PanDeCampo());
        }

        void OnAddPecosPulledPorkButtonClicked(Object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PecosPulledPork());
        }

        void OnAddRustlersRibsButtonClicked(Object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new RustlersRibs());
        }

        void OnAddTexasTeaButtonClicked(Object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTea());
        }

        void OnAddTexasTripleBurgerButtonClicked(Object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTripleBurger());
        }

        void OnAddTrailBurgerButtonClicked(Object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TrailBurger());
        }

        void OnAddWaterButtonClicked(Object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new Water());
        }

        void OnAddCowboyCoffeeButtonClicked(Object sender, RoutedEventArgs e)
        {
            OrderListView.DataContext.(new CowboyCoffee());
        }

        }
        */
    }
}
