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

        /// <summary>
        /// price of item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// list of instructions for the item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
