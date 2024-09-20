
public class JewelleryService
{
    private FileItemRepository _itemRepository;

    public JewelleryService(FileItemRepository itemRepository)
    {
        _itemRepository = itemRepository;
    }

    // Use Case #1: Show all items
    public void ShowAllItems()
    {
        var items = _itemRepository.GetAllItems();
        foreach (var item in items)
        {
            Console.WriteLine($"Id: {item.Id}, Description: {item.Description}, Price: {item.Price}");
        }
    }

    // Use Case #2: Pick an item
    public Item PickItem(int id)
    {
        return _itemRepository.GetItemById(id);
    }
}
