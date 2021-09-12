using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main() {
       int T = Int32.Parse(Console.ReadLine());
       
       
       for(int i=0;i<T;i++){
           string str = Console.ReadLine();
           long[] nums = FindNums(str);
           nums.Sort();
           Console.Write("largest Number: {0} ",nums[nums.Length-1]);
       }
       // Console.Write("Sum of x + y = "+ z);
    }
    
    static long[] FindNums(string s){
        List<long> n = new List<long>();
        str[] str = s.Split();
        
        foreach(var v in str){
            bool f = long.TryParse(v);
            if(string.Contains("9")) continue;
            else if(f) n.Add(Int32.Parse(v));
        }
        
        return n;
    }
}