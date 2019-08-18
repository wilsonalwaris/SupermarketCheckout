//-----------------------------------------------------------------------
// <copyright file="GetPopulatedItemsFromStringTest.cs" company="Wtrader Ltd.">
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
    public partial class CheckoutHelperTests
    {
        /// <summary>
        /// Defines the <see cref="GetPopulatedItemsFromStringTest" />
        /// </summary>
        public class GetPopulatedItemsFromStringTest : CheckoutHelperTests
        {
            /// <summary>
            /// The GreenPath_when_string_items_valid
            /// </summary>
            /// <param name="itemsString">The itemsString<see cref="string"/></param>
            [TestCase("A99")]
            public void GreenPath_when_string_items_valid(string itemsString)
            {
                // act
                List<Item> items = this.checkoutHelper.GetPopulatedItemsFromString(itemsString);

                // assert
                Assert.IsTrue(string.Equals(items.FirstOrDefault().Sku, "A99"));
            }

            /// <summary>
            /// The RedPath_when_string_items_invalid
            /// </summary>
            /// <param name="itemsString">The itemsString<see cref="string"/></param>
            [TestCase("")]
            public void RedPath_when_string_items_invalid(string itemsString)
            {
                // act
                List<Item> items = this.checkoutHelper.GetPopulatedItemsFromString(itemsString);

                // assert
                Assert.IsTrue(items == null);
            }
        }
    }
}
