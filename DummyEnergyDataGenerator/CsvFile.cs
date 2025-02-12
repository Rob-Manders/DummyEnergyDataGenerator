namespace DummyEnergyDataGenerator;

public static class CsvFile
{
    public static void Write(List<string> records, string path)
    {
        Console.WriteLine("Writing to file...");
        
        try
        {
            File.WriteAllLines(path, records);
        }
        catch (Exception e)
        {
            Console.WriteLine("Failed to write to file due to error:");
            Console.WriteLine(e);
            
            Environment.Exit(1);
        }
        
        Console.WriteLine("Data written.");
    }
}