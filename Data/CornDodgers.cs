using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    public class CornDodgers : Side
    {
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 512;
                        break;
                    case Size.Medium:
                        return 685;
                        break;
                    case Size.Large:
                        return 717;
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
                return "Small Corn Dodgers";
            }
            else if (this.Size == Size.Medium)
            {
                return "Medium Corn Dodgers";
            }
            else if (this.Size == Size.Large) ;
            {
                return "Large Corn Dodgers";
            }
        }

    }
}