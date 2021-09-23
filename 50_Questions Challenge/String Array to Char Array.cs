using System.IO;
using System;


class Program
{
    static void Main()
    {
        
        
       string[] str = new string[]{"a","b","c"};
       char[] c = String.Join("",str).ToCharArray();
       foreach(var v in c){
        Console.WriteLine("char: {0}",v);
       }
        //Console.WriteLine("Right Shift of {1} : {0}",right_shift,a);
    }
}