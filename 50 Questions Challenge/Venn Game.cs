using System.IO;
using System;

class Program
{
    static void Main()
    {
        // e employees total
        // 1==2==3==x
        
        //Output 1 : How many solved  the first question x
        // Output 2 : How many solved exactly one 3x
        //e-r => Participated
        // a = a + ab + ac + abc; => x + p1+p2+q :Ans 1
        // e-r = a(x) + b(x) + c(x) + p1 + p2 + p3 - q : Ans 2
        
        int p1 = Int32.Parse(Console.ReadLine());
        int p2 = Int32.Parse(Console.ReadLine());
        int p3 = Int32.Parse(Console.ReadLine());
        int q = Int32.Parse(Console.ReadLine());
        int e = Int32.Parse(Console.ReadLine());
        int r = Int32.Parse(Console.ReadLine());
        
        int  x = ((e-r)-((p1-q)+(p2-q)+(p3-q)) - q);
        int a = (x/3) + p1 + p3 - q;
        
        Console.WriteLine("The First Question was solved by: {0}",a);
        Console.WriteLine("Exactly One Question was solved by: {0}",x);
    }
}