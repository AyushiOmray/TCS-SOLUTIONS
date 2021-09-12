using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        int[] arr = new int[]{1,2,3};
        
        subsets(arr);
    }
    
    static void subsets(int[] arr){
        int[] sub = new int[arr.Length];
        helper(arr,sub,0);
    }
    
    static void helper(int[] arr,int[] sub,int p){
        if(p == arr.Length){
            foreach(var v in sub){
            Console.Write(v);
            }
             Console.WriteLine("");
        }
        else{
            sub[p] = 0;
            helper(arr,sub,p+1);
            sub[p] = arr[p];
            helper(arr,sub,p+1);
        }
    }
}

/*
Output :
Hello, World!
000
003
020
023
100
103
120
123
*/