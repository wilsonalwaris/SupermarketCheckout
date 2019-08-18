using Checkout.Types;
using System.Collections.Generic;

namespace Checkout.Services
{
    public class CheckoutHelper : ICheckoutHelper
    {
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
    }
}
