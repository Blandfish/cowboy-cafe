using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// base class representing a drink
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// variable to store size of the drink
        /// </summary>
        public Size Size;
        
        /// <summary>
        /// variable to store price of the drink.
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// varaible to store the calorie content of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// stores list of modifications to order item
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
        /// <summary>
        /// drink contains ice
        /// </summary>
        public bool Ice { get; set; } = true;
    }
}