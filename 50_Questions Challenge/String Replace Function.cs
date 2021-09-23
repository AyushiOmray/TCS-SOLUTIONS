using System.IO;
using System;

class Program
{
    static void Main()
    {
        string name = "Ayushi";
        //name.Replace(name[0].ToString(),"");
        Console.WriteLine(name.Replace(name[0].ToString(),""));
    }
}

/*
OVERLOADS
Replace(Char, Char)	
Returns a new string in which all occurrences of a specified Unicode character in this instance are replaced with another specified Unicode character.

Replace(String, String)	
Returns a new string in which all occurrences of a specified string in the current instance are replaced with another specified string.

Replace(String, String, StringComparison)	
Returns a new string in which all occurrences of a specified string in the current instance are replaced with another specified string, using the provided comparison type.

Replace(String, String, Boolean, CultureInfo)	
Returns a new string in which all occurrences of a specified string in the current instance are replaced with another specified string, using the provided culture and case sensitivity.
*/