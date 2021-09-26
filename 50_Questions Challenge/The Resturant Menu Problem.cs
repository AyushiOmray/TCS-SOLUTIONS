using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class MyClass{
    public static void Main(){
       // Console.WriteLine("Welcome to CCD!");
        char c = Char.Parse(Console.ReadLine());
        c = char.ToLower(c);
        int item = Int32.Parse(Console.ReadLine());
    
        string type = "",cat = "";
        int f = 1 ;
        
        //c -> Coffee - 3
        //t -> Tea - 8
        //s -> Soup - 4
        //b -> Beverages - 3
        
        if(c == 'c'){
            cat = "Coffee";
            switch(item){
                case 1:
                type = "Espresso";
                break;
                case 2:
                type= "Cappaccino";
                break;
                case 3:
                type = "Latte";
                break;
                default:
                f=0;
                break;
            }
        }
        else if(c=='t'){
            cat = "Tea";
            switch(item){
                case 1:
                type = "Assam";
                break;
                case 2:
                type = "Ginger";
                break;
                case 3:
                type="Cardamom";
                break;
                case 4:
                type = "Masala";
                break;
                case 5:
                type = "Lemon";
                break;
                case 6:
                type = "Green";
                break;
                case 7:
                type = "Organic Darjeeling";
                break;
                default:
                f=0;
                break;
            }
        }
        else if(c == 's'){
            cat = "Soup";
            switch(item){
                case 1:
                type = "Hot and Sour";
                break;
                case 2:
                type = "Veg Corn";
                break;
                case 3:
                type = "Tomato";
                break;
                case 4:
                type = "Spicy Tomato";
                break;
                default:
                f = 0;
                break;
            }
        }
        else if(c== 'b'){
                cat = "Drink";
                switch(item){
                    case 1:
                    cat = "Hot Chocolate";
                    break;
                    case 2:
                    cat = "Badam";
                    break;
                    case 3:
                    cat = "Badam Pista";
                    break;
                    default:
                    f=0;
                    break;
                }
            }
            else{
                f=0;
            }
        
        if(f==1){
            Console.WriteLine("Welcome to CCD!");
            Console.WriteLine($"Enjoy your {type} {cat}!");
        }
        else{
            Console.WriteLine("INVALID INPUT");
        }
        
    }
}


/*
Input:
c
1

Output:
Welcome to CCD!
Enjoy your Espresso Coffee!
*/