using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {
        
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return .60;
                        break;
                    case Size.Medium:
                        return 1.10;
                        break;
                    case Size.Large:
                        return 1.60;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                        break;
                    case Size.Medium:
                        return 5;
                        break;
                    case Size.Large:
                        return 7;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        new public bool Ice = false;

        private bool roomForCream = false;
        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
        }

       
        private bool decaf = false;
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }



        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");

                return instructions;
            }
        }
        /// <summary>
        /// override of ToString()
        /// </summary>
        public override string ToString()
        {
            return "Cowboy Coffee";
        }
    }
}