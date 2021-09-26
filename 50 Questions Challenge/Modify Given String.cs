using System.IO;
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        string s3 = Console.ReadLine();
        
        char[] vowels = new char[]{'a','e','i','o','u'};
        StringBuilder sb = new StringBuilder();
        
        foreach(var v in s1){
            if(vowels.Contains(v)){
                sb.Append('%');
            }
            else{
                sb.Append(v);
            }
        }
        
        foreach(var v in s2){
            if(!vowels.Contains(v)){
                sb.Append('#');
            }
            else{
                sb.Append(v);
            }
        }
        
        sb.Append(s3.ToUpper());
        Console.WriteLine(sb);
    }
}

/*
Input:
How
are
You

Output:
H%wa#eYOU
*/