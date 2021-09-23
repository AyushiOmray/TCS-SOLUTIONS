using System.IO;
using System;

class Program
{
    static void Main()
    {
        int val = Int32.Parse(Console.ReadLine());
        
        int p = 1;
        for(int i =0;i<4;i++){
            int temp = val%10;
            p*=temp;
            val = val/10;
        }
        Console.WriteLine(p);
    }
}