using System;  
using System.Text;  

public class Prog
{
    public static void Main(){
        /*
        1. Array.Reverse(Array,starting Index, Length);
        2. Array.Reverse(Array);
        
        */
        string s = "Ayushi";
        Console.WriteLine("Input : {0}",s);
        char[] s2 = s.ToCharArray();
        Array.Reverse(s2,2,3); 
        string s3 = new string(s2);
        Console.WriteLine("Output : {0}",s3);
    }

}

/*
Output:
Input : Ayushi
Output : Ayhsui
*/