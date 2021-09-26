using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class MyClass{
    public static void Main(){
        //1 2 4 8......{1 3 5 7}
        //1 3 9 27.....{2 4 6 8}
        //1 1 2 3 4 9 8.......
        
        int n = Int32.Parse(Console.ReadLine());
       
            
            if(n%2==0){
                int p = (n/2)-1;
                Console.WriteLine(Math.Pow(3,p));
            }
            else{
                int p = (n/2);
                Console.WriteLine(Math.Pow(2,p));
            }
        
        
    }
}

/*
Input : 16
Output: 2187
*/