using System;
using System.Collections.Generic;
using System.Linq;

public class MyClass{
    public static void Main(){
        string s = Console.ReadLine();
        Dictionary<char,int> wordc = new Dictionary<char,int>();
        
        foreach(var v in s){
            if(wordc.ContainsKey(v)){
                wordc[v] +=1;
            }
            else{
                wordc[v] = 1;
            }
            
            //Console.WriteLine($"Key: {v} Count: {wordc[v]}");
        }
        
        int max = 0;
        char k = '-';
        foreach(var v in wordc){
            if(v.Value>max){
                max = v.Value;
                k = v.Key;
            }
        }
        
        Console.WriteLine(wordc[k]);
    }
}

/*
Input: Torrento
Output: 2

*/