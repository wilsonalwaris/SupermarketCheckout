using Checkout.Types;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Checkout.Services.Tests
{
    partial class CheckoutHelperTests
    {
        public class GetPopulatedItemsFromStringTest : CheckoutHelperTests
        {
            [TestCase("A99")]
            public void GreenPath_when_string_items_valid(string itemsString)
            {
                // Act
                List<Item> items = this.checkoutHelper.GetPopulatedItemsFromString(itemsString);

                // Assert
                Assert.IsTrue(string.Equals(items.FirstOrDefault().Sku, "A99"));
            }

            [TestCase("")]
            public void RedPath_when_string_items_invalid(string itemsString)
            {
                // Act
                List<Item> items = this.checkoutHelper.GetPopulatedItemsFromString(itemsString);

                // Assert
                Assert.IsTrue(items == null);
            }
        }
    }
}
