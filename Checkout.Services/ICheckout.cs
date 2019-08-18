//-----------------------------------------------------------------------
// <copyright file="ICheckout.cs" company="Wtrader Ltd.">
//     Copyright (c) Wtrader Ltd.. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Checkout.Services
{
    using Checkout.Types;

    /// <summary>
    /// Defines the <see cref="ICheckOut" />
    /// </summary>
    public interface ICheckOut
    {
        /// <summary>
        /// The Scan
        /// </summary>
        /// <param name="item">The item<see cref="Item"/></param>
        /// <returns>The <see cref="Item"/></returns>
        Item Scan(Item item);
    }
}
