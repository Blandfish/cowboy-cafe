using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class for the water menu item
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// getter returns price of water
        /// </summary>
        public override double Price
        {
            get
            {
                return .12;
            }
        }

        /// <summary>
        /// getter returns calorie count of water
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }
        
        /// <summary>
        /// stores whether the drink has a lemon
        /// </summary>
        private bool lemon = false;

        public bool Lemon
        {
            get { return lemon; }
            set { Lemon = value; }
        }

        /// <summary>
        /// contains special instructions for the drink.
        /// </summary>

        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }
    }
}