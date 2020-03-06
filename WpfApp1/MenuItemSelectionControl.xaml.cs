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

            //Event listeners for menuitem buttons

            AddCowpokeChiliButton.Click += OnItemAddButtonClicked; // changed may need to revert for milestone2
            AddAngryChickenButton.Click += OnItemAddButtonClicked;
            AddBakedBeansButton.Click += OnItemAddButtonClicked;
            AddCornDodgersButton.Click += OnItemAddButtonClicked;
            AddDakotaDoubleBurgerButton.Click += OnItemAddButtonClicked;
            AddPanDeCampoButton.Click += OnItemAddButtonClicked;
            AddPecosPulledPorkButton.Click += OnItemAddButtonClicked;
            AddRustlersRibsButton.Click += OnItemAddButtonClicked;
            AddTexasTripleBurgerButton.Click += OnItemAddButtonClicked;
            AddTrailBurgerButton.Click += OnItemAddButtonClicked;
            AddChiliCheeseFriesButton.Click += OnItemAddButtonClicked;
            AddTexasTeaButton.Click += OnItemAddButtonClicked;
            AddWaterButton.Click += OnItemAddButtonClicked;
            AddJerkedSodaButton.Click += OnItemAddButtonClicked;
            AddCowboyCoffeeButton.Click += OnItemAddButtonClicked;
            

        }

        /// <summary>
        /// Event handler for menuitem buttons calls correct constructor for button chosen and adds to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnItemAddButtonClicked(object sender,RoutedEventArgs e)
        {
            orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    IOrderItem nItem;
                    switch(button.Tag)
                    {
                        case "CowpokeChili":
                            nItem  = new CowpokeChili();
                            var screen = new CustomizeCowpokeChili();
                            screen.DataContext = nItem;
                            order.Add(new CowpokeChili());
                            orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "AngryChicken":
                            nItem = new AngryChicken();
                            // var screen = new CustomizeCowpokeChili();
                            //screen.DataContext = entree;
                            order.Add(new AngryChicken());
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;

                        case "BakedBeans":
                            nItem = new BakedBeans();
                            // var screen = new CustomizeCowpokeChili();
                            //screen.DataContext = entree;
                            order.Add(new BakedBeans());
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;

                        case "ChiliCheeseFries":
                            nItem = new ChiliCheeseFries();
                            // var screen = new CustomizeCowpokeChili();
                            //screen.DataContext = entree;
                            order.Add(new ChiliCheeseFries());
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "CornDodgers":
                            nItem = new CornDodgers();
                            // var screen = new CustomizeCowpokeChili();
                            //screen.DataContext = entree;
                            order.Add(new CornDodgers());
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "CowboyCoffee":
                            nItem = new CowboyCoffee();
                            // var screen = new CustomizeCowpokeChili();
                            //screen.DataContext = entree;
                            order.Add(new CowboyCoffee());
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "DakotaDoubleBurger":
                            nItem = new DakotaDoubleBurger();
                            // var screen = new CustomizeCowpokeChili();
                            //screen.DataContext = entree;
                            order.Add(new DakotaDoubleBurger());
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "JerkedSoda":
                            nItem = new JerkedSoda();
                            // var screen = new CustomizeCowpokeChili();
                            //screen.DataContext = entree;
                            order.Add(new JerkedSoda());
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "PanDeCampo":
                            nItem = new PanDeCampo();
                            // var screen = new CustomizeCowpokeChili();
                            //screen.DataContext = entree;
                            order.Add(new PanDeCampo());
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "PecosPulledPork":
                            nItem = new PecosPulledPork();
                            // var screen = new CustomizeCowpokeChili();
                            //screen.DataContext = entree;
                            order.Add(new PecosPulledPork());
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "RustlersRibs":
                            nItem = new RustlersRibs();
                            // var screen = new CustomizeCowpokeChili();
                            //screen.DataContext = entree;
                            order.Add(new RustlersRibs());
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "TexasTea":
                            nItem = new TexasTea();
                            // var screen = new CustomizeCowpokeChili();
                            //screen.DataContext = entree;
                            order.Add(new TexasTea());
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "TexasTripleBurger":
                            nItem = new TexasTripleBurger();
                            // var screen = new CustomizeCowpokeChili();
                            //screen.DataContext = entree;
                            order.Add(new TexasTripleBurger());
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "TrailBurger":
                            nItem = new BakedBeans();
                            // var screen = new CustomizeCowpokeChili();
                            //screen.DataContext = entree;
                            order.Add(new TrailBurger());
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        case "Water":
                            nItem = new BakedBeans();
                            // var screen = new CustomizeCowpokeChili();
                            //screen.DataContext = entree;
                            order.Add(new CowboyCoffee());
                            //orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                    }
                    
                }
            }
        }

        void AddItemCustomizationScreen(IOrderItem item, FrameworkElement screen)
        {
            var order = DataContext as Order;
            if (order == null) throw new Exception("");
            if (screen != null)
            {
                var orderControl = this.FindAncestor<OrderControl>();
                if (orderControl == null) throw new Exception("");

                screen.DataContext = item;
                orderControl.SwapScreen(screen);
            }
        }
        
    }
}
