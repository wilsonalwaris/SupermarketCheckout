//-----------------------------------------------------------------------
// <copyright file="Checkout.cs" company="Wtrader Ltd.">
//     Copyright (c) Wtrader Ltd.. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Checkout.Services
{
    using Checkout.Types;
    using System.Collections.Generic;

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
        /// The GetTotalPrice
        /// </summary>
        /// <param name="pricePopulatedItems">The pricePopulatedItems<see cref="List{Item}"/></param>
        /// <returns>The <see cref="decimal"/> the total price</returns>
        public decimal GetTotalPrice(List<Item> pricePopulatedItems)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// The Scan
        /// </summary>
        /// <param name="item">The item<see cref="string"/></param>
        /// <returns>The <see cref="Item"/></returns>
        public List<Item> Scan(string item)
        {
            var items = this.checkoutHelper.GetPopulatedItemsFromString(item);
            return this.checkoutHelper.GetPricesForItems(items);
        }
    }
}
