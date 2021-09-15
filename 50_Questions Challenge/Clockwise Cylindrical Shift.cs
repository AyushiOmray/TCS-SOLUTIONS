using System.IO;
using System;

class Program
{
    static void Main()
    {
        //10 20 30 40 50
        //2 -> 40 50 10 20 30
        //1-> 50 10 20 30 40
        int N  = Int32.Parse(Console.ReadLine());
        string str = Console.ReadLine();
        string[] s = str.Split();
        int k = Int32.Parse(Console.ReadLine());
        int[] ip = new int[N];
        
        for(int i=0;i<N;i++){
            ip[i] = Int32.Parse(s[i]);
        }
        
        int[] res = new int[N];
        
        int val = k;
        for(int i=0;i<N;i++){
            if(val>=N){val = 0;}
            res[val] = ip[i];
            val+=1;
        }
       
        for(int i=0;i<N;i++){
            Console.WriteLine(res[i]);
        }
        
        
    }
}