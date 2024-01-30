namespace OperationsWithFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filePath = "input.txt";
                decimal result = HelpingMethods.CalculateAverage(filePath);
                Console.WriteLine(result);

                filePath = "output.txt";
                string content = result.ToString();
                HelpingMethods.WriteContentToFile(filePath, content);
            }
            catch (FileNotFoundException ex)
            {
                HelpingMethods.HandleException("Input file not found.", ex);
            }
            catch (FormatException ex)
            {
                HelpingMethods.HandleException("File contains non-numeric data.", ex);
            }
            catch (IOException ex)
            {
                HelpingMethods.HandleException("An I/O exception occurred during file operations.", ex);
            }
            catch (Exception ex)
            {
                HelpingMethods.HandleException("An unexpected error occurred.", ex);
            }
        }
    }
}
