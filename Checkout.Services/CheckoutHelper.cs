//-----------------------------------------------------------------------
// <copyright file="CheckoutHelper.cs" company="Wtrader Ltd.">
//     Copyright (c) Wtrader Ltd.. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Checkout.Services
{
    using Checkout.Types;
    using System.Collections.Generic;
    using System.Linq;

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
            if (items == null || !items.Any())
            {
                return null;
            }

            foreach (var item in items)
            {
                item.Price = this.GetPrice(item).Price;
            }

            return items;
        }

        /// <summary>
        /// The GetBasket
        /// </summary>
        /// <param name="pricePopulatedItems">The pricePopulatedItems<see cref="List{Item}"/></param>
        /// <returns>The <see cref="Dictionary{string, int}"/></returns>
        public Dictionary<string, int> GetBasket(List<Item> pricePopulatedItems)
        {
            var basket = (from item in pricePopulatedItems
                          group item by item.Sku
                         into groupedItems
                          select groupedItems).ToDictionary(gi => gi.Key, gi => gi.Count());

            return basket;
        }

        /// <summary>
        /// The GetPrice
        /// </summary>
        /// <param name="item">The item<see cref="Item"/></param>
        /// <returns>The <see cref="Item"/></returns>
        private Item GetPrice(Item item)
        {
            List<Item> priceList = this.GetPriceList();
            return priceList.FirstOrDefault(i => string.Equals(i.Sku, item.Sku));
        }

        /// <summary>
        /// The GetPriceList
        /// </summary>
        /// <returns>The <see cref="List{Item}"/></returns>
        private List<Item> GetPriceList()
        {
            return new List<Item>() {
                new Item() { Sku = "A99", Price = 0.50m},
                new Item() { Sku = "B15", Price = 0.30m},
                new Item() { Sku = "C40", Price = 0.60m},
            };
        }
    }
}
