namespace OperationsWithFiles
{
    public class HelpingMethods
    {
        public static decimal CalculateAverage(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int sum = 0;
            int number_of_elements = 0;
            foreach (string line in lines)
            {
                string[] elems = line.Split();
                number_of_elements += elems.Length;
                for (int i = 0; i < elems.Length; i++)
                {
                    sum += int.Parse(elems[i]);
                }
            }

            decimal result = (decimal)sum / number_of_elements;
            return result;
        }

        public static void WriteContentToFile(string filePath, string content)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(content);
            }
        }

        public static void HandleException(string errorMessage, Exception ex)
        {
            Console.WriteLine($"Error: {errorMessage}");
            Console.WriteLine($"Exception Details: {ex.Message}");

            // Log the exception to error_log.txt
            LogExceptionToFile("error_log.txt", ex);
        }

        static void LogExceptionToFile(string logFilePath, Exception ex)
        {
            string logMessage = $"{DateTime.Now}: {ex.GetType().FullName} - {ex.Message}\n{ex.StackTrace}\n\n";

            File.AppendAllText(logFilePath, logMessage);
        }
    }
}
