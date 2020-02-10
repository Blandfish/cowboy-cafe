using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    public class PanDeCampo : Side
    {
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 227;
                        break;
                    case Size.Medium:
                        return 269;
                        break;
                    case Size.Large:
                        return 367;
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
    }
}