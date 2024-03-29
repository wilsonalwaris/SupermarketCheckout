﻿//-----------------------------------------------------------------------
// <copyright file="ICheckoutHelper.cs" company="Wtrader Ltd.">
//     Copyright (c) Wtrader Ltd.. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Checkout.Services
{
    using Checkout.Types;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="ICheckoutHelper" />
    /// </summary>
    public interface ICheckoutHelper
    {
        /// <summary>
        /// The GetPopulatedItemsFromString
        /// </summary>
        /// <param name="itemsString">The itemsString<see cref="string"/></param>
        /// <returns>The <see cref="List{Item}"/></returns>
        List<Item> GetPopulatedItemsFromString(string itemsString);

        /// <summary>
        /// The GetPricesForItems
        /// </summary>
        /// <param name="items">The items<see cref="List{Item}"/></param>
        /// <returns>The <see cref="List{Item}"/></returns>
        List<Item> GetPricesForItems(List<Item> items);

        /// <summary>
        /// The GetBasket
        /// </summary>
        /// <param name="items">The items<see cref="List{Item}"/></param>
        /// <returns>The <see cref="Dictionary{string, int}"/></returns>
        Dictionary<string, int> GetBasket(List<Item> items);

        /// <summary>
        /// The GetPrice
        /// </summary>
        /// <param name="item">The item<see cref="Item"/></param>
        /// <returns>The <see cref="Item"/></returns>
        Item GetItemDetails(string sku);
    }
}
