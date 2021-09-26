using System.Buffers;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            string[] s3 = s1.ToCharArray().Select(x => x.ToString()).ToArray(); 
            Combinations(s3);

            var m = l.FindAll(x=>x==s2);
            Console.WriteLine(m.Count());
        }

        public static List<string> l = new List<string>();

        public static void Combinations(string[] arr){
            string[] sub = new string[arr.Length];
            helper(arr,sub,0);
        }

        public static void helper(string[] arr,string[] sub,int p){
            if(p==arr.Length){
                string v = string.Join("",sub);
                l.Add(v);
            }
            else{
                sub[p] = "";
                helper(arr,sub,p+1);
                sub[p] = arr[p];
                helper(arr,sub,p+1);
            }
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