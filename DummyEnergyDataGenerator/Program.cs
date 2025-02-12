namespace DummyEnergyDataGenerator;

class Program
{
    static void Main(string[] args)
    {
        List<string> dates = Dates.Generate();
        List<string> addresses = Addresses.CreateList();
        
        Names names = new();
        
        List<string> records = Records.Create(dates, names, addresses);
        
        CsvFile.Write(records, "/home/rob/energy-data.csv");
    }
}