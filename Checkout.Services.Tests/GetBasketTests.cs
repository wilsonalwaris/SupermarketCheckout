//-----------------------------------------------------------------------
// <copyright file="GetBasketTests.cs" company="Wtrader Ltd.">
//     Copyright (c) Wtrader Ltd.. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Checkout.Services.Tests
{
    using NUnit.Framework;

    /// <summary>
    /// Defines the <see cref="CheckoutHelperTests" />
    /// </summary>
    public partial class CheckoutHelperTests
    {
        /// <summary>
        /// Defines the <see cref="GetBasketTests" />
        /// </summary>
        public class GetBasketTests : CheckoutHelperTests
        {
            /// <summary>
            /// The GetBasketTest
            /// </summary>
            /// <param name="items">The items<see cref="string"/></param>
            /// <param name="expectedCount">The expectedCount<see cref="int"/></param>
            [TestCase("A99,A99", 2)]
            [TestCase("A99,A99,A99", 3)]
            public void GetBasketTest(string items, int expectedCount)
            {
                // arrange
                var pricedItems = this.checkoutHelper.GetPopulatedItemsFromString(items);

                // act
                var basket = this.checkoutHelper.GetBasket(pricedItems);
                basket.TryGetValue("A99", out int count);

                // assert
                Assert.AreEqual(expectedCount, count);
            }
        }
    }
}
