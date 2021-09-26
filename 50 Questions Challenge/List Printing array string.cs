using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    
    static void Main()
    {
       string[] str1 = new string[]{"a","b","c","d"};
       string[] str2 = new string[]{"ee","bb"};
     string[] str3 = new string[]{"aev","cnb"};
       
       List<string[]> l = new List<string[]>();
       l.Add(str1);
       l.Add(str2);
       l.Add(str3);
       
       foreach(var v in l){
          Console.WriteLine(String.Join("",v));
       }
    }
}

/*
Output:
abcd
eebb
aevcnb
*/