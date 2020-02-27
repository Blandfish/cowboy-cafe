using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class for the texas tea menu item.
    /// </summary>
    public class TexasTea : Drink
    {
        /// <summary>
        /// used to get the price for different sizes of Texas Tea.
        /// </summary>
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

        /// <summary>
        /// used to get the calorie count for different sizes of tea.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        if (!sweet)
                        {
                            return 5;
                        }
                        else return 10;
                        break;
                    case Size.Medium:
                        if (!sweet)
                        {
                            return 11;
                        }
                        else return 22;
                        break;
                    case Size.Large:
                        if (!sweet)
                        {
                            return 18;
                        }
                        else return 36;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        private bool ice = true;
        public bool Ice
        {
            get { return ice; }
            set {ice = value; }
        }
        /// <summary>
        /// true == sweet tea
        /// </summary>
        private bool sweet = true;
        public bool Sweet
        {
            get { return sweet; }
            set { sweet = value; }
        }
        /// <summary>
        /// true == tea contains lemon
        /// </summary>
        private bool lemon = false;

        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }

        /// <summary>
        /// list of special instructions for the drink.
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
        /// <summary>
        /// override of ToString()
        /// </summary>
        public override string ToString()
        {
            if (Sweet)
            {
                if (this.Size == Size.Small)
                {
                    return "Small Texas Sweet Tea";
                }
                else if (this.Size == Size.Medium)
                {
                    return "Medium Texas Sweet Tea";
                }
                else if (this.Size == Size.Large) ;
                {
                    return "Large Texas Sweet Tea";
                }
            }
            else
            {
                if (this.Size == Size.Small)
                {
                    return "Small Texas Plain Tea";
                }
                else if (this.Size == Size.Medium)
                {
                    return "Medium Texas Plain Tea";
                }
                else if (this.Size == Size.Large) ;
                {
                    return "Large Texas Plain Tea";
                }
            }
        }
    }
}
