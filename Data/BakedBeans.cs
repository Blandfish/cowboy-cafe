using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    public class BakedBeans : Side
    {
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 312;
                        break;
                    case Size.Medium:
                        return 378;
                        break;
                    case Size.Large:
                        return 410;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

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
                        return 1.79;
                        break;
                    case Size.Large:
                        return 1.99;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// override of ToString()
        /// </summary>
        public override string ToString()
        {
            if (this.Size == Size.Small)
            {
                return "Small Baked Beans";
            }
            else if (this.Size == Size.Medium)
            {
                return "Medium Baked Beans";
            }
            else if (this.Size == Size.Large) ;
            {
                return "Large Baked Beans";
            }
        }
    }
}