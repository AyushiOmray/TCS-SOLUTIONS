using System.IO;
using System;

class Program
{
    static void Main()
    {
        string str = Console.ReadLine();
        int n = Int32.Parse(str[0].ToString());
        
        int c0 = 0, c1=0,c2 = 0;
        for(int i=0;i<n;i++){
            string str2 = Console.ReadLine();
            int v = Int32.Parse(str2[0].ToString());
            if(v==0){c0+=1;}
            else if(v==1){c1+=1;}
            else if(v==2){c2+=1;}
        }
        
        for(int i=0;i<c1;i++){
        Console.Write(1 + " ");
        }
        for(int i=0;i<c0;i++){
        Console.Write(0 + " ");
        }
        for(int i=0;i<c2;i++){
        Console.Write(2 + " ");
        }
    }
}

/*

Input :
6 - Total count of number
0 - 1st value of list
1 - 2nd value of list
2 - 3rd value of list
0 - 4th value of list
1 - 5th value of list
2 - 6th value of list

Output:
1 1 0 0 2 2

*/