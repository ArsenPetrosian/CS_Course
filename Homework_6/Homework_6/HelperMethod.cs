namespace AsyncConsoleTextFileEditor
{
    public class HelperMethod
    {
        private SemaphoreSlim semaphore = new SemaphoreSlim(1, 1);

        public async Task EditTextFileAsync()
        {
            Console.Write("Enter the path of the text file: ");
            string? filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File does not exist.");
                return;
            }
            try
            {
                await semaphore.WaitAsync();

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string content = await reader.ReadToEndAsync();
                    Console.WriteLine($"Content of {filePath}:");
                    Console.WriteLine(content);
                }

                Console.WriteLine("Enter new content");

                List<string> lines = new List<string>();

                string? line;

                while((line = Console.ReadLine()) != null)
                {
                    lines.Add(line);
                }

                await semaphore.WaitAsync();

                using (StreamWriter writer = new StreamWriter(filePath, false))
                {
                    foreach(string l in lines)
                    {
                        await writer.WriteLineAsync(l);
                    }
                }

                Console.WriteLine($"File {filePath} has been updated successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
            finally
            {
                semaphore.Release();
            }
        }
    }
}
