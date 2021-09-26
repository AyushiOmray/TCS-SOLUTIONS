using System.IO;
using System;

class Program
{
    static void Main()
    {
        int num = Int32.Parse(Console.ReadLine());
        Check(num);
       
        
    }
    
    static void Check(int num){
        int sqrt  = (int)Math.Sqrt(num);
        
        if(num%2==0){
             Console.WriteLine("Not prime");
        }
        else{
            for(int i=3;i<=sqrt;i+=2){
               
                if(num%i == 0){
                    Console.WriteLine("Not prime");
                    return;
                }
            }
             Console.WriteLine("Prime");
            return ;
        }
    }
}