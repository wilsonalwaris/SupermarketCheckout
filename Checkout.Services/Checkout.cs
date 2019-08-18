//-----------------------------------------------------------------------
// <copyright file="Checkout.cs" company="Wtrader Ltd.">
//     Copyright (c) Wtrader Ltd.. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Checkout.Services
{
    using Checkout.Types;

    /// <summary>
    /// Defines the <see cref="CheckOut" />
    /// </summary>
    public class CheckOut : ICheckOut
    {
        /// <summary>
        /// Defines the checkoutHelper
        /// </summary>
        private ICheckoutHelper checkoutHelper;

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckOut"/> class.
        /// </summary>
        /// <param name="checkoutHelper">The checkoutHelper<see cref="ICheckoutHelper"/></param>
        public CheckOut(ICheckoutHelper checkoutHelper)
        {
            this.checkoutHelper = checkoutHelper;
        }

        /// <summary>
        /// The Scan
        /// </summary>
        /// <param name="item">The item<see cref="Item"/></param>
        /// <returns>The <see cref="Item"/></returns>
        public Item Scan(Item item)
        {
            return null;
        }
    }
}
