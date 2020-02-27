using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class for the rustlers ribs
    /// </summary>
    public class RustlersRibs : Entree
    {
        /// <summary>
        /// the price of the Ribs
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }
        /// <summary>
        /// the Calorie content of the ribs
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }
        /// <summary>
        /// prints instructions for the order
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                return instructions;
            }
        }
        /// <summary>
        /// override of ToString()
        /// </summary>
        public override string ToString()
        {
            return "Rustler's Ribs";
        }

    }

}