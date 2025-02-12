namespace DummyEnergyDataGenerator;

public static class Addresses
{
    public static List<string> CreateList(int approxAmount = 0)
    {
        List<string> addressList = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Data", "addresses.txt")).ToList();
        int limit = approxAmount == 0 ? addressList.Count : approxAmount;

        List<string> addresses = new();
        foreach (string address in addressList)
        {
            int numberOfHouses = new Random().Next(0, 20);

            for (int i = 1; i <= numberOfHouses; i++)
            {
                addresses.Add($"{i} {address}");
            }
            
            if (addresses.Count > limit) break;
        }
        
        return addresses;
    }
}