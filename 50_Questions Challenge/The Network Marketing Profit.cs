using System.IO;
using System;

class Program
{
    static void Main()
    {
        //N Height of tree=>3
        //M Profit earned at Nth Level=>100
        //P Percentage profit that needs to be passed to supervisor=>10
        int N = Int32.Parse(Console.ReadLine());
        int M = Int32.Parse(Console.ReadLine());
        int P = Int32.Parse(Console.ReadLine());
        
        double amt,per,val=M;
        
        for(int i=0;i<N-1;i++){
             per = P * 0.01;
             amt = (per * val);
             val = amt;
        }
        M = (int)val;
        Console.WriteLine("The Profit earned by top node: {0}", M);
    }
}