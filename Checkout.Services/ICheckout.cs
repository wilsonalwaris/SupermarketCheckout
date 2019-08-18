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
    }
}
