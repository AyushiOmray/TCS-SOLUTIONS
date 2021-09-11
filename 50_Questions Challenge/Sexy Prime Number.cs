using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program{
    public static void Main(){
       int l = Int32.Parse(Console.ReadLine());
       int u = Int32.Parse(Console.ReadLine());
       
       List<int> primes= new List<int>();
       for(int i=l;i<=u;i++){
           bool c = CheckPrime(i);
           if(c){primes.Add(i);}
           
       }
       
       SortedList<int,int> pairs = new SortedList<int,int>();
       primes.Distinct();
       for(int i=0;i<primes.Count;i++){
           for(int j=i+1;j<primes.Count;j++){
               int a = primes[i];
               int b = primes[j];
               if(Math.Abs(a-b)==6){
                     pairs.Add(a,b);
               }
           }
       }
       
       
        Console.WriteLine("Count:{0}", pairs.Count());
    }
    
    static bool CheckPrime(int num){
       // bool f = true;
        if(num==2) return true;
        
        for(int i=2;i<num;i++){
            if(num%i==0) return false;
        }
        
        return true;
    }
}

/*
Input:
2
30

Output:
6
*/