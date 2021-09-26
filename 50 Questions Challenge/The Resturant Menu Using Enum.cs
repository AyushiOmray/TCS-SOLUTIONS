using System.IO;
using System;

class Program
{
    enum coffee {
         Espresso = 1 ,
         Cappaccino = 2,
         Latte = 3
    }
    
    enum tea{
        Assam = 1,
        Ginger = 2,
        Cardamom = 3,
        Masala = 4,
        Lemon = 5,
        Green = 6,
        OrganicDarjeeling = 7
    }
    
    
    
    static void Main()
    {
        char c = Char.Parse(Console.ReadLine());
        int item = Int32.Parse(Console.ReadLine());
        string type = "",cat = "";
        int f = 1;
        
        if(c == 'c'){
            cat = "Coffee";
            type = ((coffee)item).ToString();
        }
        else if(c == 't'){
            cat = "Tea";
            type = ((tea)item).ToString();
        }
        else{
            f = 0;
        }
        
        //For invalid values
        if(type.Length == 1){
        bool b = Char.IsNumber(Char.Parse(type));
            if(b){
                f =0;
            }
        }
        
        if(f==1){
            Console.WriteLine($"Please enjoy your {type} {cat}");
        }
        else{
            Console.WriteLine("Invalid");
        }
    }
}

/* 
Input:

c
1

Output:
Please enjoy your Espresso Coffee

*/
