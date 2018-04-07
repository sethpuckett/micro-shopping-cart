namespace MicroShoppingCart
{
  public interface IEventStore
  {
      void Raise(string eventName, object content);
  }
}