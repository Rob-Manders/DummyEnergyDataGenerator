namespace DummyEnergyDataGenerator;

public static class Dates
{
    public static List<string> Generate(int year = 2024)
    {
        long dateUnixTime = new DateTime(year, 1, 1, 0, 0, 0).Ticks;

        List<string> dates = new();
        for (int i = 0; i < (IsLeapYear(year) ? 366 : 365); i++)
        {
            dates.Add(new DateTime(dateUnixTime).ToString("yyyy-MM-dd"));
            
            dateUnixTime += TimeSpan.TicksPerDay;
        }
        
        return dates;
    }

    private static bool IsLeapYear(int year)
    {
        return (year % 400 == 0 && year % 100 == 0) || year % 4 == 0;
    }
}