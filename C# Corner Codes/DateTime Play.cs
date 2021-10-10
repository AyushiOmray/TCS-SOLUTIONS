using System.IO;
using System;

class Program
{
    enum months{
        January = 1,
        Feburary = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }
    
    static void Main()
    {
        int dd = Int32.Parse(Console.ReadLine());
        string m = Console.ReadLine();
        int yr = Int32.Parse(Console.ReadLine());
        
        int mn = (int)((months)Enum.Parse(typeof(months),m));
        
        DateTime d1 = new DateTime(yr,mn,dd);
        
        DateTime d2 = d1.AddDays(183);
        
    System.Console.WriteLine("Initial DateTime = {0:y} {0:dd}", d1);
    System.Console.WriteLine("\nNew DateTime (After adding days) = {0:dd} {0:MMMM} {0:yyyy}", d2);
    }
}