using System.IO;
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] str = new string[]
        {
            "apple",
            "banana",
            "guava",
            "carrot",
            "watermelon"
        };
        
        List<string> l = str.ToList();
        //One more interesting way could be:   
        //List<string> l = new List<string>(str);
        l.Remove("carrot");
        
        Array.Resize(ref str, 4);
        
        for(int i=0;i<4;i++){
            str[i] = l[i];
        }
        
        foreach(var fruit in str){
            Console.WriteLine(fruit);
        }
    }
}