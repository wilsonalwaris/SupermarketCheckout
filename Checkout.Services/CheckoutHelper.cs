//-----------------------------------------------------------------------
// <copyright file="CheckoutHelper.cs" company="Wtrader Ltd.">
//     Copyright (c) Wtrader Ltd.. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Checkout.Services
{
    using Checkout.Types;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="CheckoutHelper" />
    /// </summary>
    public class CheckoutHelper : ICheckoutHelper
    {
        /// <summary>
        /// The GetPopulatedItemsFromString
        /// </summary>
        /// <param name="itemsString">The itemsString<see cref="string"/></param>
        /// <returns>The <see cref="List{Item}"/></returns>
        public List<Item> GetPopulatedItemsFromString(string itemsString)
        {
            if (string.IsNullOrEmpty(itemsString))
            {
                return null;
            }

            // populate items list from csv string of items
            List<Item> items = new List<Item>();
            foreach (var stritem in itemsString.Split(","))
            {
                items.Add(new Item { Sku = stritem });
            }

            return items;
        }

        /// <summary>
        /// The GetPricesForItems
        /// </summary>
        /// <param name="items">The items<see cref="List{Item}"/></param>
        /// <returns>The <see cref="List{Item}"/></returns>
        public List<Item> GetPricesForItems(List<Item> items)
        {
            return null;
        }
    }
}
