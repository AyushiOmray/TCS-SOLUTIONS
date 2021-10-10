using System.IO;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int N = Int32.Parse(Console.ReadLine());
        
        for(int i=0;i<N;i++){
            string str = Console.ReadLine();
            string[] s = str.Split('-');
            int y = Int32.Parse(s[0]);
            int m = Int32.Parse(s[1]);
            int d = Int32.Parse(s[2]);
            DateTime date = new DateTime(y,m,d);
             Console.WriteLine("{0}",date.DayOfWeek.ToString().ToUpper());
        }
    }
}

/*
Input: 
2
2000-01-10
2000-01-11

Output:
MONDAY
TUESDAY
*/