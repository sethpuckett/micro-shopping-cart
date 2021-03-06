using System.Collections.Generic;

namespace MicroShoppingCart
{
  public class ShoppingCart
  {

    private List<ShoppingCartItem> items;

    public void AddItems(IEnumerable<ShoppingCartItem> shoppingCartItems, IEventStore eventStore)
    {
      foreach (var item in shoppingCartItems)
      {
        this.items.Add(item);
        eventStore.Raise("ShoppingCartItemAdded", new { UserId, item });
      }
    }

    public void RemoveItems(IEnumerable<ShoppingCartItem> shoppingCartItems, IEventStore eventStore)
    {
      foreach (var item in shoppingCartItems)
      {
        this.items.Remove(item);
        eventStore.Raise("ShoppingCartItemRemoved", new { UserId, item });
      }
    }
  }
}