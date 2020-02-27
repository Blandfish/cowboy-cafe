using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Order
    {
        /// <summary>
        /// holds the set of items ordered
        /// </summary>
        public IEnumerable<IOrderItem> Items => throw new NotImplementedException();
        /// <summary>
        /// holds final price pretax
        /// </summary>
        public double Subtotal => 0;
        /// <summary>
        /// adds an item to the order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item) { }

        public void Remove(IOrderItem item) { }
    }
}
