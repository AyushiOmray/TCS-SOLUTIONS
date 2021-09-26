using System.IO;
using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
      
      var v = new int[]{1,2,3,4,7,3231,23,24};
      var x = new List<int>();
      x.Add(3);
      x.Add(6);
      x.Add(1);
      
      Console.WriteLine($"{v.Length} and {x.Count}");
    }
}