using System.IO;
using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        List<int> factors = new List<int>();
        
        factors.Add(1);
        for(int i=2;i<n;i++){
            if(CheckPrime(i)){
                if(n%i==0){factors.Add(i);}
            }
        }
        
        factors.Sort();
        int len = factors.Count;
        //HCF
        Console.WriteLine(factors[len-1]);
    }
    
    static bool CheckPrime(int i){
        if(i==2) return true;
        for(int j=3;j<i;j+=2){
            if(i%j==0) return false;
        }
        
        return true;
    }
}

