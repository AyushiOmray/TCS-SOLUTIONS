using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

public class Program{
    public static void Main(){
        string[] s = {"M","A","a","z","v","Q"};
        
        SortedList<string, int> S = new SortedList<string, int>();
        for(int i=0;i<s.Length;i++){
            S.Add(s[i],i);
        }
        
        foreach(var v in S){
            Console.WriteLine("Key: {0} and Value: {1}",v.Key,v.Value);
        }
    }
}

/*

Output:
Key: a and Value: 2
Key: A and Value: 1
Key: M and Value: 0
Key: Q and Value: 5
Key: v and Value: 4
Key: z and Value: 3

*/