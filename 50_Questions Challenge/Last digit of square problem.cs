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
          int i = Int32.Parse(Console.ReadLine());
          if(i<=0){Console.WriteLine("Invalid Input");}
          else{
              int temp = (i*i)%10;
              if(temp == i){Console.WriteLine("Correct Number");}
              else{Console.WriteLine("Incorrect Input");}
          }
         //Console.WriteLine("Hello");
      }
    }
}
