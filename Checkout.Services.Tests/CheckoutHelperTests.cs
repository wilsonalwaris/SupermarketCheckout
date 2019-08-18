using NUnit.Framework;

namespace Checkout.Services.Tests
{
    public partial class CheckoutHelperTests
    {
        protected ICheckoutHelper checkoutHelper;

        [SetUp]
        public void Setup()
        {
            this.checkoutHelper = new CheckoutHelper();
        }
    }
}
