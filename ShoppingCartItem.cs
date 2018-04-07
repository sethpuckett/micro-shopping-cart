namespace MicroShoppingCart
{
  public class ShoppingCartItem
  {
    private int Id;
    private object productName;
    private object productDescription;
    private object price;

    public ShoppingCartItem(int id, object productName, object productDescription, object price)
    {
      this.Id = id;
      this.productName = productName;
      this.productDescription = productDescription;
      this.price = price;
    }
  }
}