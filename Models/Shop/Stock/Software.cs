namespace TMPS_Labs.Models.Shop.Stock;

public class Software : Item {
  public override ItemCategory Category { get; } = ItemCategory.Hardware;

  public Software(Shop shop) : base(shop, "Undefined", 0) { }

  public Software(Shop shop, string name, double price) : base(shop, name, price) { }

  public override bool Sell(Person.Person to, int count) {
    return true;
  }

  public override bool Discount(double newPrice) {
    throw new NotImplementedException();
  }
}
