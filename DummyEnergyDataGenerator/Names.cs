namespace DummyEnergyDataGenerator;

public class Names
{
    private readonly List<string> _firstNames;
    private readonly List<string> _middleNames;
    private readonly List<string> _lastNames;

    private readonly Random _random = new();

    public Names()
    {
        _firstNames = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Data", "first-names.txt")).ToList();
        _middleNames = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Data", "middle-names.txt")).ToList();
        _lastNames = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Data", "last-names.txt")).ToList();
    }
    
    public string New()
    {
        string name = $"{_firstNames[_random.Next(0, _firstNames.Count - 1)]} ";
        
        if (HasMiddleName())
        {
            name += $"{_middleNames[_random.Next(0, _middleNames.Count - 1)]} ";
        }
        
        name += _lastNames[_random.Next(0, _lastNames.Count - 1)];
        
        return name;
    }

    private bool HasMiddleName()
    {
        return _random.Next(1, 5) == 1;
    }
}