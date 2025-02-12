namespace DummyEnergyDataGenerator;

public static class Records
{
    public static List<string> Create(List<string> dates, Names names, List<string> addresses)
    { 
        Random random = new();
        
        List<string> records = new();
        int numberOfRecords = 0;
        
        records.Add("date,name,address,gas,electricity");
        
        foreach (string address in addresses)
        {
            string personalData = $"{names.New()},\"{address}\"";
            
            foreach (string date in dates)
            {
                string record = $"{date},{personalData},{random.Next(1, 10)},{random.Next(1, 10)}";
                
                records.Add(record);
                numberOfRecords++;
        
                Console.WriteLine($"Created record {numberOfRecords}: {record}");
            }
        }
        
        return records;
    }
}