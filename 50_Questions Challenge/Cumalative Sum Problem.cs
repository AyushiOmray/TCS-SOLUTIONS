using System.IO;
using System;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        string[] str = s.Split();
        
        int sum =0;
        int[] nums = new int[str.Length];
        for(int i=0;i<str.Length;i++){
            nums[i] = Int32.Parse(str[i]);
            sum+=nums[i];
        }
        
        foreach(var v in nums){
            if(sum-v<=0){break;}
            Console.Write(sum-v+" ");
            sum-=v;
        }
    }
}

/*
Input:
10 20 30 40 50
Output:
140 120 90 50 
*/