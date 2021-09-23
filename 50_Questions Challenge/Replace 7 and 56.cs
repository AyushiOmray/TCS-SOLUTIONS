using System.IO;
using System;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        
        s =s.Replace("7","");
        s =s.Replace("56","");
        
        Console.WriteLine(s);
    }
}

/*
Limitation it removes 7 from 57 but we need to preserve it

*/