using System.IO;
using System;

class Program
{
    static void Main()
    {
        char i = '3';
        char j = 'x';
        var v = char.IsDigit(i); 
        var v2 = char.IsLetter(j);
        var v3 = char.IsLetterOrDigit(j);
        Console.WriteLine(v);
        Console.WriteLine(v2);
        Console.WriteLine(v3);

    }
}