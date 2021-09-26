using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class MyClass{
    
    public static void Main(){
        // 0 2 4 6 ......
        // 0 1 3 5 ...
        // 0 0 1 2 3 4 5 6 7 8 9 10......
        
        int n = Int32.Parse(Console.ReadLine());
        
        int p;
        if(n == 1 || n == 2){
            p = 0;
        }
        else{
            p = n-2;
        }
        
        Console.WriteLine(p);
    }
}