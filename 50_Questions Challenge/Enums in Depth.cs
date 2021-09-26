using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class MyClass{
    enum test {
        a = 1,
        b = 2,
        c = 5,
        q = 17
    }
    
    public static void Main(){
        int val = (int)test.q;
        
        Console.WriteLine(val);
        
        var val2 = (test)3;
        
        Console.WriteLine(val2);
        Console.WriteLine(val2.GetType());
        
        var val3= (test)51;
    
       Console.WriteLine(val3);
       
       //var val4 = test.m;
       
      /*
      Above line gives an error : Compilation failed: 1 error(s), 0 warnings
main.cs(28,24): error CS0117: `MyClass.test' does not contain a definition for `m'
main.cs(7,10): (Location of the symbol related to previous error)
*/
    }
}

