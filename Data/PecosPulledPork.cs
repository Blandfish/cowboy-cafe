using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class for the pecos pulled pork
    /// </summary>
    public class PecosPulledPork : Entree
    {
        /// <summary>
        /// the price of the Pecos Pulled Pork
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }
        /// <summary>
        /// the calorie content of the Pecos Pulled Pork
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }

        private bool bread = true;
        /// <summary>
        /// If the Pulled Pork has bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        private bool pickle = true;
        /// <summary>
        /// If the Pulled Pork has pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// prints instructions for the order
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");
                return instructions;
            }
        }

        public override string ToString()
        {
            return "Peco's Pulled Pork";
        }

    }

}