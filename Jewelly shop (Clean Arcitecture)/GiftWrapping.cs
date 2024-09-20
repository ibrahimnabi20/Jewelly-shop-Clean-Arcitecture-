public class GiftWrapping : Item
{
    public Item Item { get; set; }
    public decimal GiftWrapPrice { get; set; } = 10.0m;  

    public GiftWrapping(Item item) : base(item.Id, item.Description, item.Price)
    {
        this.Item = item;
    }

    public override decimal Price => Item.Price + GiftWrapPrice;
}
