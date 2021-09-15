using System;  
using System.Text;  

public class Prog
{
    public static void Main(){
        string s = "Ayushi";
        
        char[] s2 = s.ToCharArray();
        Array.Reverse(s2); //Because here we intend to reverse the letters of the word
        string s3 = new string(s2);
        Console.WriteLine(s3);
    }

}

/*
Output:
ihsuyA
*/