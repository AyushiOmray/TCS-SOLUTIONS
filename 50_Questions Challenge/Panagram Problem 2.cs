using System.IO;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string str = Console.ReadLine();
        char[] s = str.ToCharArray();
        
        int val = 64; 
        int f = 0;
        
        for(int i=0;i<26;i++){
            val+=1;
            char c = (char)val;
            char sc = char.ToLower(c);
            //Console.WriteLine("val:{0}, char: {1}",val,sc);
            
            
            if(s.Contains(sc)){
                continue;
            }
            else{
                f=1;
                break;
            }
            
        }
        
        if(f==1){
        Console.WriteLine("Not a panagram");
        }
        else{
            Console.WriteLine("Panagram");
        }
    }
}