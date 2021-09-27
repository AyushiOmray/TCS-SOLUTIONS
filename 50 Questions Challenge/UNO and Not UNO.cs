using System.IO;
using System;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        
        while(n>9){
            n = DigitSum(n); 
        }
        
        if(n==1){
        Console.WriteLine("UNO");
        }
        else{
            Console.WriteLine("No UNO");
        }
    }
    
    public static long DigitSum(long n){
        long sum = 0;
        while(n>0){
            long temp = n%10;
            sum+=temp;
            n = n/10;
        }
        
        return sum;
    }
}

/*
Input: 1252
Output: UNO

Input2: 123
Output: Not UNO

*/