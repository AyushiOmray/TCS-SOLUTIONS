using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace myapp
{
    class Program
    {
      public static void Main(){
         var s = Console.ReadLine();
         char c = s[0];
         int i;
         if(c>='a' && c<='z'){
             Console.WriteLine("Lower Alphabet");
         }
         else if(c>='A' && c<='Z'){
             Console.WriteLine("Upper Alphabet");
         }
         //TRY PARSE IMPLEMENTATION
         else if(Int32.TryParse(c.ToString(),out i)){
             Console.WriteLine("Number");
         }
         else{
         Console.WriteLine("Character");
         }
      }
    }
}
