namespace DummyEnergyDataGenerator;

class Program
{
    static void Main(string[] args)
    {
        List<string> records = new();
        int numberOfRecords = 0;
        
        records.Add("name,address,gas,electricity");
        
        Names names = new();
        
        foreach (string address in new Addresses(10).Get())
        {
            string pii = names.New() + ',';
            pii += $"\"{address}\"";
            
            for (int i = 0; i < 365; i++)
            {
                Random random = new();

                string record = pii + ',';

                record += $"{random.Next(1, 10)},";
                record += random.Next(1, 10).ToString();
                
                records.Add(record);
                numberOfRecords++;
    
                Console.WriteLine($"Created record: {numberOfRecords}");
            }
        }
        
        Console.WriteLine($"Number of records: {numberOfRecords}");
        Console.WriteLine("Writing to file...");

        try
        {
            File.WriteAllLines(Path.Combine("/home/rob/energy-data.csv"), records);
        }
        catch (Exception e)
        {
            Console.WriteLine("Failed to write to file");
            Console.WriteLine(e);
            
            Environment.Exit(1);
        }
        
        Console.WriteLine("Data written.");
    }
}