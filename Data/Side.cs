using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {
        public  event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public Size Size { get; set; }

        private Size size
        {
            get { return size; }
            set 
            { 
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("size"));
            }
        }
        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        public List<string> SpecialInstructions { get; }
    }
}
