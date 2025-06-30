namespace ProductsJsonApp.Services;

class Application
{
    private readonly ProductMenuService productMenuService;

    public Application()
    {
        this.productMenuService = new ProductMenuService();
    }

    public void Start()
    {
        string startMenuText = @"Press number of operation: 

1. Create new product
2. Show all products
3. Exit";

        Console.WriteLine("Welcome to Product application!\n");
        while(true)
        {
            Console.WriteLine(startMenuText);

            ConsoleKey consoleKey = Console.ReadKey(true).Key;
            Console.Clear();

            try
            {
                switch (consoleKey)
                {
                    case ConsoleKey.D1:
                        productMenuService.Create();
                        break;
                    case ConsoleKey.D2:
                        productMenuService.Read();
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D3:
                        return;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: '{ex.Message}'");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey(true);
            }

            Console.Clear();
        }
    }
}