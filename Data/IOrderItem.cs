using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// an interface representing a singel item in an order
    /// </summary>
    public interface IOrderItem
    {
        double Price { get; }

        List<string> SpecialInstructions { get; }
    }
}
