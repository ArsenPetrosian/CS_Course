namespace AsyncConsoleTextFileEditor
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to Asynchronous Console Text File Editor");

            HelperMethod helperMethod = new HelperMethod();
            bool isExited = false;

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Edit a text file");
                Console.WriteLine("2. Exit");

                Console.Write("Enter your choice: ");
                string? choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        await helperMethod.EditTextFileAsync();
                        break;
                    case "2":
                        Console.WriteLine("Exiting");
                        isExited = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again");
                        break;
                }

                if (isExited)
                {
                    break;
                }
            }
        }
    }
}
