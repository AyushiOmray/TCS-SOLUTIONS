using System.IO;
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string str = Console.ReadLine();
        string[] s = str.Split();
        int len = s.Length;
        
         int[] blocks = new int[len];
        
        for(int i=0;i<len;i++){
            blocks[i] = Int32.Parse(s[i]);
        }
        
        //left array and right array
        int[] left = new int[len];
        int[] right = new int[len];
        
        //left Array entries
        int max = 0;
        for(int i=0;i<len;i++){
            max = Max(max,blocks[i]);
            left[i] = max;
            
        }
        
        //right Array entries
        max = 0;
        for(int i=len-1;i>=0;i--){
            max = Max(max,blocks[i]);
            right[i] = max;
        }
        
       //Output
       int water = 0;
       
       for(int i=0;i<len;i++){
           int min = Min(left[i],right[i]);
           //Console.WriteLine("min: "+min);
           water+=(min - blocks[i]);
       }
       
       Console.WriteLine(water);
    }
    
    static int Max(int a,int b){
        if(a>=b) return a;
        else return b;
    }
    
     static int Min(int a,int b){
        if(a<=b) return a;
        else return b;
    }
}

/*
Input:
0 1 0 2 1 0 1 3 2 1 2 1

Output:
6
*/