//-----------------------------------------------------------------------
// <copyright file="GetPricesForItemsTests.cs" company="Wtrader Ltd.">
//     Copyright (c) Wtrader Ltd.. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Checkout.Services.Tests
{
    using Checkout.Types;
    using NUnit.Framework;

    /// <summary>
    /// Defines the <see cref="CheckoutHelperTests" />
    /// </summary>
    public partial class CheckoutTests
    {
        /// <summary>
        /// Defines the <see cref="GetPricesForItemsTest" />
        /// </summary>
        public class ScanItemsTest : CheckoutTests
        {
            [Test]
            public void GreenPath_when_valid_item_provided()
            {
                // arrange
                var item = new Item { Sku = "A99" };

                // act
                var pricePopulatedItem = this.checkout.Scan(item);

                // assert 
                Assert.IsTrue(pricePopulatedItem.Price == 0.05m);
            }
        }
    }
}
