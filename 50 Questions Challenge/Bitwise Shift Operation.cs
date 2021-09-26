using System.IO;
using System;

class Program
{
    static void Main()
    {
        //Left Shift & Right Shift
        
        int a = 60; //0011 1100
        
        int left_shift = a<<3; // multiply by (a<<n) 2 ^ n
        int right_shift = a>>2; // divide by (a>>n) 2^n
        Console.WriteLine("Left Shift of {1}: {0}",left_shift,a);
        Console.WriteLine("Right Shift of {1} : {0}",right_shift,a);
    }
}