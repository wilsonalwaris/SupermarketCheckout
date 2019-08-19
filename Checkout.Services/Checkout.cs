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
            var basket = this.checkoutHelper.GetBasket(pricePopulatedItems);

            var totalPrice = 0.0m;
            foreach (var item in basket)
            {
                var itemPrice = this.GetItemPrice(item.Key, item.Value);
                totalPrice += itemPrice;
            }

            return totalPrice;
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

        /// <summary>
        /// The GetItemPrice
        /// </summary>
        /// <param name="sku">The sku<see cref="string"/></param>
        /// <param name="quantity">The quantity<see cref="int"/></param>
        /// <returns>The <see cref="decimal"/></returns>
        private decimal GetItemPrice(string sku, int quantity)
        {
            var itemDetails = this.checkoutHelper.GetItemDetails(sku);

            // if special price not present
            // or quantity is less than offer quantity 
            if (!(itemDetails.OfferQuantity > 0) || quantity < itemDetails.OfferQuantity)
            {
                return (quantity * itemDetails.Price);
            }

            var quotient = quantity / itemDetails.OfferQuantity;
            var remainder = quantity % itemDetails.OfferQuantity;

            return (quotient * itemDetails.OfferPrice) + (remainder * itemDetails.Price);
        }
    }
}
