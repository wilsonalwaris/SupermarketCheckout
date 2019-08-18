//-----------------------------------------------------------------------
// <copyright file="GetPricesForItemsTests.cs" company="Wtrader Ltd.">
//     Copyright (c) Wtrader Ltd.. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Checkout.Services.Tests
{
    using Checkout.Types;
    using Moq;
    using NUnit.Framework;
    using System.Collections.Generic;
    using System.Linq;

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
            /// <summary>
            /// The GreenPath_mocked_dependencies_test
            /// </summary>
            [Test]
            public void GreenPath_mocked_dependencies_test()
            {
                // arrange 
                var items = new List<Item> { new Item { Sku = "A99", Price = 0.50m } };
                this.checkoutHelper.Setup(coh => coh.GetPopulatedItemsFromString(It.IsAny<string>())).Returns(items);
                this.checkoutHelper.Setup(coh => coh.GetPricesForItems(It.IsAny<List<Item>>())).Returns(items);

                // act
                var pricePopulatedItem = this.checkoutWithMockedDependencies.Scan("A99");

                // assert 
                Assert.IsTrue(pricePopulatedItem.First().Price == 0.50m);
            }

            /// <summary>
            /// The GreenPath_when_valid_item_provided
            /// </summary>
            /// <param name="items">The items<see cref="string"/></param>
            [TestCase("A99")]
            public void GreenPath_when_valid_item_provided(string items)
            {
                // act
                var pricePopulatedItems = this.checkout.Scan(items);

                // assert 
                Assert.IsTrue(pricePopulatedItems.First().Price == 0.50m);
            }

            /// <summary>
            /// The GreenPath_when_valid_multiple_items_provided
            /// </summary>
            /// <param name="items">The items<see cref="string"/></param>
            [TestCase("A99,B15")]
            public void GreenPath_when_valid_multiple_items_provided(string items)
            {
                // act
                var pricePopulatedItems = this.checkout.Scan(items);

                // assert 
                Assert.IsTrue(pricePopulatedItems.Last().Price == 0.30m);
            }
        }
    }
}
