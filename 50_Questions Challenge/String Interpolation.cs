using System.IO;
using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
       string[] str = s.Split();
       
       int n = Int32.Parse(str[0]);
       int p = Int32.Parse(str[1]);
        
        Console.WriteLine($"{n} power {p} : "+Math.Pow(n,p));
    }
}