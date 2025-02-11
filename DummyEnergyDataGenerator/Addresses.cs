namespace DummyEnergyDataGenerator;

public class Addresses
{
    private readonly List<string> _addresses = new();
    private readonly int _limit;

    public Addresses(int limit = 1000)
    {
        _limit = limit;
        
        CreateAddressList();
    }

    public List<string> Get()
    {
        return _addresses;
    }

    private void CreateAddressList()
    {
        List<string> addressList = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Data", "addresses.txt")).ToList();

        foreach (string address in addressList)
        {
            int numberOfHouses = new Random().Next(0, 20);

            for (int i = 1; i <= numberOfHouses; i++)
            {
                _addresses.Add($"{i} {address}");
            }
            
            if (_addresses.Count > _limit) break;
        }
    }
}