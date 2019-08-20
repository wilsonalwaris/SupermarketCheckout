//-----------------------------------------------------------------------
// <copyright file="ICheckout.cs" company="Wtrader Ltd.">
//     Copyright (c) Wtrader Ltd.. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Checkout.Services
{
    using Checkout.Types;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="ICheckOut" />
    /// </summary>
    public interface ICheckOut
    {
        /// <summary>
        /// The Scan
        /// </summary>
        /// <param name="item">The item<see cref="string"/></param>
        /// <returns>The <see cref="List{Item}"/></returns>
        List<Item> Scan(string item);

        /// <summary>
        /// The GetTotalPrice
        /// </summary>
        /// <param name="pricePopulatedItems">The pricePopulatedItems<see cref="List{Item}"/></param>
        /// <returns>The <see cref="decimal"/></returns>
        decimal GetTotalPrice(List<Item> pricePopulatedItems);
    }
}
