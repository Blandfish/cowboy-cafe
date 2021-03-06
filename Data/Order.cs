﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public Order()//??????????????
        {
            /*AngryChicken testItem = new AngryChicken();
            items.Add(testItem);*/

            OrderNumber += 1;

        }
        /// <summary>
        /// holds the set of items ordered
        /// </summary>
        public IEnumerable<IOrderItem> Items
        {
            get { return items.ToArray(); }
        }
        
        /// <summary>
        /// holds final price pretax
        /// </summary>
        /// 


        private List<IOrderItem> items = new List<IOrderItem>();
        public double Subtotal
        {
            
            get
            {
                double sub = 0;
                foreach (IOrderItem i in Items)
                {
                    sub += i.Price;
                }
                return sub;
            }
        }

        public static uint OrderNumber { get; set; }
        /// <summary>
        /// adds an item to the order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item) 
        {
            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged += OnItemPropertyChanged;
            }
            
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items.Price"));
        }
        /// <summary>
        /// removes an item from the order
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item) 
        {
            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged -= OnItemPropertyChanged;
            }
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items.Price"));
        }
        
        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("subtotal"));
            }
        }

        
    }
}
