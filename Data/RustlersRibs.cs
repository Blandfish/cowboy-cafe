using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    public class RustlersRibs
    {
        /// <summary>
        /// the price of the Ribs
        /// </summary>
        public double Price
        {
            get
            {
                return 7.50;
            }
        }
        /// <summary>
        /// the Calorie content of the ribs
        /// </summary>
        public uint Calories
        {
            get
            {
                return 894;
            }
        }
        /// <summary>
        /// prints instructions for the order
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                return instructions;
            }
        }
    }

}