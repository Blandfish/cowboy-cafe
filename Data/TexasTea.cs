using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
    {
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.00;
                        break;
                    case Size.Medium:
                        return 1.50;
                        break;
                    case Size.Large:
                        return 2.00;
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
                        return 10 * (!Sweet/2);
                        break;
                    case Size.Medium:
                        return 22 * (!Sweet / 2);
                        break;
                    case Size.Large:
                        return 36 * (!Sweet / 2);
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        private bool sweet = true;

        public bool Sweet
        {
            get { return sweet; }
            set { sweet = value; }
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