using System.Collections.Generic;
using Checkout.Types;

namespace Checkout.Services
{
    public interface ICheckoutHelper
    {
        List<Item> GetPopulatedItemsFromString(string itemsString);
    }
}