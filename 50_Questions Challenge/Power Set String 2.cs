using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    
    static void Main()
    {
       string[] str = new string[]{"a","b","c"};
       Subset(str);
       
       foreach(var v in l){
           string k = String.Join("",v);
          Console.WriteLine(k);
       }
    }
    
    static void Subset(string[] s){
        string[] sub = new string[s.Length];
        helper(s,sub,0);
    } 
    
    static List<string[]> l = new List<string[]>();
    static void helper(string[] arr,string[] sub,int p){
        if(p==arr.Length){
           l.Add(sub);
        }
        else{
            
            sub[p] = "";
            helper(arr,sub,p+1);
            sub[p] = arr[p];
            helper(arr,sub,p+1);
        }
    }
    
    
}

/*
It doesn't work as expected as sub is an array and we are passing the refrence and it converts the last value of array to string 
*/