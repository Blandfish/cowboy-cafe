using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// base class representing an entree
    /// </summary>
    public abstract class Entree: IOrderItem, INotifyPropertyChanged
    {
        
        public abstract double Price { get; }

        public abstract uint Calories { get; }

        public virtual List<string> SpecialInstructions { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChange(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PropertyName"));

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

    }
}