public class Item
{
    public int Id { get; set; }
    public string Description { get; set; }
    public virtual decimal Price { get; set; }  

    public Item(int id, string description, decimal price)
    {
        Id = id;
        Description = description;
        Price = price;
    }
}
