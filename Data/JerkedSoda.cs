using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class for the Jerked Soda menu item
    /// </summary>
    public class JerkedSoda : Drink
    {

        /// <summary>
        /// getter returns the price of the jerked soda at various sizes.
        /// </summary>
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

        /// <summary>
        /// getter returns the calorie count of the jerked soda at various sizes
        /// </summary>
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
        /// <summary>
        ///  stores the flavor of the soda
        /// </summary>
        public SodaFlavor Flavor
        {
            get;
            set;
        }

        /// <summary>
        /// getter returns a list of special instructions for the jerked soda.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }

        /// <summary>
        /// override of ToString()
        /// </summary>
        public override string ToString()
        {
            if (Size == Size.Small)
            {
                if (Flavor == SodaFlavor.BirchBeer)
                {
                    return "Small Birch Beer Jerked Soda";
                }
                if (Flavor == SodaFlavor.CreamSoda)
                {
                    return "Small Cream Soda Jerked Soda";
                }
                if (Flavor == SodaFlavor.OrangeSoda)
                {
                    return "Small Orange Soda Jerked Soda";
                }
                if (Flavor == SodaFlavor.RootBeer)
                {
                    return "Small Root Beer Jerked Soda";
                }
                if (Flavor == SodaFlavor.Sarsparilla)
                {
                    return "Small Sarsparilla Jerked Soda";
                }
            }
            else if (Size == Size.Medium)
            {
                if (Flavor == SodaFlavor.BirchBeer)
                {
                    return "Medium Birch Beer Jerked Soda";
                }
                if (Flavor == SodaFlavor.CreamSoda)
                {
                    return "Medium Cream Soda Jerked Soda";
                }
                if (Flavor == SodaFlavor.OrangeSoda)
                {
                    return "Medium Orange Soda Jerked Soda";
                }
                if (Flavor == SodaFlavor.RootBeer)
                {
                    return "Medium Root Beer Jerked Soda";
                }
                if (Flavor == SodaFlavor.Sarsparilla)
                {
                    return "Medium Sarsparilla Jerked Soda";
                }
            }
            else if (Size == Size.Large)
            {
                if (Flavor == SodaFlavor.BirchBeer)
                {
                    return "Large Birch Beer Jerked Soda";
                }
                if (Flavor == SodaFlavor.CreamSoda)
                {
                    return "Large Cream Soda Jerked Soda";
                }
                if (Flavor == SodaFlavor.OrangeSoda)
                {
                    return "Large Orange Soda Jerked Soda";
                }
                if (Flavor == SodaFlavor.RootBeer)
                {
                    return "Large Root Beer Jerked Soda";
                }
                if (Flavor == SodaFlavor.Sarsparilla)
                {
                    return "Large Sarsparilla Jerked Soda";
                }
            }
            
            return "";

        }


    }
}