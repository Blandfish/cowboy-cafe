using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                        break;
                    case Size.Medium:
                        return 2.10;
                        break;
                    case Size.Large:
                        return 2.59;
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
                        return 110 ;
                        break;
                    case Size.Medium:
                        return 146;
                        break;
                    case Size.Large:
                        return 198;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        public SodaFlavor Flavor
        {
            get;
            set;
        }
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }
    }
}