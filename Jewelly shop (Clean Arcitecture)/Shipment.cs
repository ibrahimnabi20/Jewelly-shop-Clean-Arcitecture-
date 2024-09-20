public class Shipment : Item
{
    public Item Item { get; set; }
    public decimal ShippingPrice { get; set; } = 10.0m;  

    public Shipment(Item item) : base(item.Id, item.Description, item.Price)
    {
        this.Item = item;
    }

    public override decimal Price => Item.Price + ShippingPrice;
}
