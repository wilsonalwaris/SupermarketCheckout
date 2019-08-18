//-----------------------------------------------------------------------
// <copyright file="GetPricesForItemsTests.cs" company="Wtrader Ltd.">
//     Copyright (c) Wtrader Ltd.. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Checkout.Services.Tests
{
    using Checkout.Types;
    using NUnit.Framework;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="CheckoutHelperTests" />
    /// </summary>
    internal partial class CheckoutHelperTests
    {
        /// <summary>
        /// Defines the <see cref="GetPricesForItemsTest" />
        /// </summary>
        public class GetPricesForItemsTest : CheckoutHelperTests
        {
            /// <summary>
            /// The GreenPath_Valid_Items_List_Provided
            /// </summary>
            [Test]
            public void GreenPath_when_valid_items_Provided()
            {
                // arrange
                var items = new List<Item> {
                    new Item { Sku = "A99"}
                };

                // act
                var pricePopulatedItems = this.checkoutHelper.GetPricesForItems(items);

                // assert
                Assert.IsTrue(pricePopulatedItems.FirstOrDefault().Price == 0.50m);
            }

            /// <summary>
            /// The RedPath_empty_items_sent
            /// </summary>
            [Test]
            public void RedPath_when_empty_items_sent()
            {
                // arrange
                var items = new List<Item>();

                // act
                var pricePopulatedItems = this.checkoutHelper.GetPricesForItems(items);

                // assert
                Assert.IsTrue(pricePopulatedItems == null);
            }
        }
    }
}
