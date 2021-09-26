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
       string s1 = Console.ReadLine();
       string s2 = Console.ReadLine();
       char[] ch = s1.ToCharArray();
       
       string[] str = new string[ch.Length];
       for(int i=0;i<ch.Length;i++){
         str[i] = ch[i].ToString();
       }
       Subset(str);
       
       int c = 0;
       
       foreach(var v in l){
         if(String.Equals(s2,v)){c+=1;}
           //Console.WriteLine(v);
       }
       
       Console.WriteLine(c);
      
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

/*
Input 1:
Indiiian
Indian

Output:
3

Input 2:
ggoog
go

Output:
4
*/