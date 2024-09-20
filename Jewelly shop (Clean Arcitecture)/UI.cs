
class Program
{
    static void Main(string[] args)
    {
        string filePath = @"C:\items.txt";
        FileItemRepository itemRepo = new FileItemRepository(filePath);
        Console.WriteLine($"Using file path: {filePath}");

        JewelleryService service = new JewelleryService(itemRepo);

        // Use Case #1: Show all available items
        Console.WriteLine("Available Items:");
        service.ShowAllItems();

        // Use Case #2: Pick an item
        Console.WriteLine("Please enter the ID of the jewellery item you'd like to purchase:");
        int id = int.Parse(Console.ReadLine());
        var selectedItem = service.PickItem(id);

        // Use Case #3: Add/Ignore Gift Wrapping
        Console.WriteLine("Would you like to add gift wrapping to your order? (yes or no)");
        string giftWrapChoice = Console.ReadLine();
        if (giftWrapChoice == "yes")
        {
            selectedItem = new GiftWrapping(selectedItem);
        }

        // Use Case #4: Add/Ignore Shipment
        Console.WriteLine("Would you like to include shipment for your order? (yes or no)");
        string shipmentChoice = Console.ReadLine();
        if (shipmentChoice == "yes")
        {
            selectedItem = new Shipment(selectedItem);
        }

        // Use Case #5: View Order with total price
        Console.WriteLine($"Your final order: {selectedItem.Description}, Total Price: {selectedItem.Price}");
    }
}
