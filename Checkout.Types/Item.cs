//-----------------------------------------------------------------------
// <copyright file="Item.cs" company="Wtrader Ltd.">
//     Copyright (c) Wtrader Ltd.. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Checkout.Types
{
    /// <summary>
    /// Defines the <see cref="Item" />
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Gets or sets the Sku
        /// </summary>
        public string Sku { get; set; }

        /// <summary>
        /// Gets or sets the Price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the OfferQuantity
        /// </summary>
        public int OfferQuantity { get; set; }

        /// <summary>
        /// Gets or sets the OfferPrice
        /// </summary>
        public decimal OfferPrice { get; set; }
    }
}
