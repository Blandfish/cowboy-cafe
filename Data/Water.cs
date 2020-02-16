using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {
        public override double Price
        {
            get
            {
                return .12;
            }
        }
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }

        private bool lemon = fales;

        public bool Lemon
        {
            get { return lemon; }
            set { Lemon = value; }
        }


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