using NUnit.Framework;

namespace Checkout.Services.Tests
{
    public class CheckoutTests
    {
        private ICheckoutHelper checkoutHelper;

        [SetUp]
        public void Setup()
        {
            this.checkoutHelper = new CheckoutHelper();
        }

        [TestCase("A99")]
        public void ItemScanTest(string itemsString)
        {
            List<Item> items = this.CheckoutHelper.GetPopulatedItemsFromString(itemsString);
        }

    }
}
