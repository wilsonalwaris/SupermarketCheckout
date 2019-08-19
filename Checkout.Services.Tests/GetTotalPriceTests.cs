//-----------------------------------------------------------------------
// <copyright file="GetTotalPriceTests.cs" company="Wtrader Ltd.">
//     Copyright (c) Wtrader Ltd.. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Checkout.Services.Tests
{
    using NUnit.Framework;

    /// <summary>
    /// Defines the <see cref="CheckoutTests" />
    /// </summary>
    public partial class CheckoutTests
    {
        /// <summary>
        /// Defines the <see cref="GetTotalPriceTests" />
        /// </summary>
        public class GetTotalPriceTests : CheckoutTests
        {
            /// <summary>
            /// The GetTotalPriceTest
            /// </summary>
            /// <param name="items">The items<see cref="string"/></param>
            [TestCase("A99,B15")]
            public void GetTotalPriceTest(string items)
            {
                // arrange 
                var pricePopulatedItems = this.checkout.Scan(items);
                var expectedTotalPrice = 0.80m;

                // act
                var totalPrice = this.checkout.GetTotalPrice(pricePopulatedItems);

                // assert 
                Assert.AreEqual(expectedTotalPrice, totalPrice);
            }
        }
    }
}
