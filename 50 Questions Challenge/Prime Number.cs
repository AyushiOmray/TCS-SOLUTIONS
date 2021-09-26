using System.IO;
using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
      int n = Int32.Parse(Console.ReadLine());
      Console.WriteLine(CheckPrime(n));
    }
    
    static bool CheckPrime(int i){
        if(i==2 || i == 3) return true;
        for(int j=2;j<=Math.Sqrt(i);j++){
            if(i%j == 0){
                return false;
            }
        }
        
        return true;
    }
}