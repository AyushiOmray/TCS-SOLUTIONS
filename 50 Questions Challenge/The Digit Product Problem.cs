using System.IO;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int a  = Int32.Parse(Console.ReadLine());
        
        int res = GiveNum(a);
        
        Console.WriteLine(res);
    }
    
    public static int GiveNum(int a){
        int i = 10, val = 1;
        do{
            i+=1;
            val = Diff(i);
        }while(val !=a);
        
        return i;
    }
    
    public static int Diff(int b){
        int temp;
        int p = 1;
        while(b>0){
            temp = b%10;
            p = p * temp;
            b = b/10;
        }
        return p;
    }
}


/*
Code to find the least number whose digit's product will equal to our input
*/