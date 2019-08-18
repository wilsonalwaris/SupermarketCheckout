//-----------------------------------------------------------------------
// <copyright file="CheckoutHelperTests.cs" company="Wtrader Ltd.">
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
        /// Defines the checkoutHelper
        /// </summary>
        private ICheckoutHelper checkoutHelper;

        /// <summary>
        /// The Setup
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.checkoutHelper = new CheckoutHelper();
        }
    }
}
