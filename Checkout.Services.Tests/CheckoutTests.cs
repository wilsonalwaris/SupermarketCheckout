//-----------------------------------------------------------------------
// <copyright file="CheckoutTests.cs" company="Wtrader Ltd.">
//     Copyright (c) Wtrader Ltd.. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Checkout.Services.Tests
{
    using Moq;
    using NUnit.Framework;

    /// <summary>
    /// Defines the <see cref="CheckoutTests" />
    /// </summary>
    public partial class CheckoutTests
    {
        /// <summary>
        /// Defines the checkoutWithMockedDependencies
        /// </summary>
        private ICheckOut checkoutWithMockedDependencies;

        /// <summary>
        /// Defines the checkout
        /// </summary>
        private ICheckOut checkout;

        /// <summary>
        /// Defines the checkoutHelper
        /// </summary>
        private Mock<ICheckoutHelper> checkoutHelper;

        /// <summary>
        /// The Setup
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.checkoutHelper = new Mock<ICheckoutHelper>();
            this.checkoutWithMockedDependencies = new CheckOut(this.checkoutHelper.Object);
            this.checkout = new CheckOut(new CheckoutHelper());
        }
    }
}
