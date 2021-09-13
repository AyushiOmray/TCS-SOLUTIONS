using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static List<string> l = new List<string>();
    
    static void Main()
    {
       string[] str = new string[]{"a","b","c","d"};
       Subset(str);
       
       foreach(var v in l){
           Console.WriteLine(v);
       }
      
    }
    
    static void Subset(string[] s){
        string[] sub = new string[s.Length];
         helper(s,sub,0);
    } 
    
    static void helper(string[] arr,string[] sub,int p){
        
        if(p==arr.Length){
            string val = String.Join("",sub);
             //Console.WriteLine(val);
             l.Add(val);
        }
        else{
            sub[p] = "";
            helper(arr,sub,p+1);
            sub[p] = arr[p];
            helper(arr,sub,p+1);
        }
        
    }
    
    
}