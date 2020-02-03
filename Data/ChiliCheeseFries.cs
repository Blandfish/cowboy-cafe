using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    class ChiliCheeseFries : side
    {
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 433;
                        break;
                    case Size.Medium:
                        return 524;
                        break;
                    case Size.Large:
                        return 610;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}
