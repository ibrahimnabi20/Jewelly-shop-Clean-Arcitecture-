
public class FileItemRepository
{
    private string filePath;

    public FileItemRepository(string filePath)
    {
        this.filePath = filePath;
    }

    // Fetch all items from the file
    public List<Item> GetAllItems()
    {
        List<Item> items = new List<Item>();

        try
        {
            // Read all lines from the file
            foreach (var line in File.ReadAllLines(filePath))
            {
                var data = line.Split(',');
                items.Add(new Item(int.Parse(data[0]), data[1], decimal.Parse(data[2])));
            }
        }
        catch (Exception ex)
        {
            // Print out the error message if something goes wrong
            Console.WriteLine($"Error reading file: {ex.Message}");
        }

        return items;
    }

    internal Item GetItemById(int id)
    {
        throw new NotImplementedException();
    }
}
