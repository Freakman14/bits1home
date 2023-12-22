var d1 = new Date();
d1.Day = 28;
d1.Month = 9;
d1.Year = 2005;
System.Console.WriteLine("Day: " + d1.GetDate());
System.Console.WriteLine("Month: " + d1.GetMonth());
System.Console.WriteLine("Year: " + d1.GetYear());
System.Console.WriteLine(d1.ToString());

public class Date
{
    private int _day;
    private int _month;
    private int _year;

    public int Day
    {
        get
        {
            return _day;
        }
        set
        {
            _day = value;
        }
    }

    public int Month
    {
        get
        {
            return _month;
        }
        set
        {
            _month = value;
        }
    }
    public int Year
    {
        get
        {
            return _year;
        }
        set
        {
            _year = value;
        }
    }

    public int GetDate()
    {
        return Day;
    }
    public int GetMonth()
    {
        return Month;
    }
    public int GetYear()
    {
        return Year;
    }
    // public int Day;
    // public int Month;
    // public int Year;

    public string ToString()
    {
        return $"{Day}/{Month}/{Year}";
    }
}
