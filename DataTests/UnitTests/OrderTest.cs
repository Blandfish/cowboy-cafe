using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.UnitTests
{
    public class OrderTest
    {
        class MockOrderItem : IOrderItem
        {
            public double Price { get; set; }
            public List<string> SpecialInstructions { get; set; }
        }
        //Adding something to the order should have it appear in the order

        [Fact]
        public void AddedOrderItemsAppearInItemsProperty()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);

            Assert.Contains(item, order.Items);
        }
        [Fact]
        public void RemovedOrderItemDoesNotAppearInItemsProperty()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            order.Remove(item);
            Assert.DoesNotContain(item, order.Items);


        }

        /// <summary>
        //[Theory]
        //[InlineData(new double[0])]
        //[InlineData(new double[] { 10, 15, 17 })]
        //[InlineData(new double[] { })]
        // [InlineData(new double[] { 0, -1, 5 })]
        //[InlineData(new double[] { -100, -5 })]
       // public void SubtotalShouldBeTheSumOfOrderItemPrices(IEnumerable<double> prices)
        //{
            //var order = new Order();
           // foreach (var price in prices)
           // {
               // order.Add(new MockOrderItem()
               // {
               //     Price = price
              //  });
          //  }

          //  Assert.Equal(total, order.Subtotal);
       // }
        /// </summary>
        /// <param name="prices"></param>


        //removing something from the order should remove it from the items property

        //get the price - needs to be correct for the items added


        [Fact]
        public void ItemsShouldContainOnlyAddedItems()
        {
            var items = new IOrderItem[]
            {
                new MockOrderItem() {Price = 3},
                new MockOrderItem() {Price = 4},
                new MockOrderItem() {Price = 87 },
            };
            var order = new Order();
            foreach(var item in items)
            {
                order.Add(item);
            }

            Assert.Equal(items.Length, order.Items.Count());

            foreach(var item in items)
            {
                Assert.Contains(item, order.Items);
            }
        }

        
    }

}
