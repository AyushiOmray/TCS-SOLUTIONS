using System.IO;
using System;

class Program
{
    static void Main()
    {
        //ST
        //No of disticts
        //A-Z Allowed
        //0-9 4 digits allowed
        int dis = Int32.Parse(Console.ReadLine());
        string s1 = Console.ReadLine();
        char[] str = s1.ToCharArray();
        char c1 = str[0];
        char c2 = str[2];
        int camt = ((int)(c2-c1)+1);
        int c = camt*camt;
        string str2 = Console.ReadLine();
        
        int num1 = Int32.Parse(str2[0].ToString());
        int num2 = Int32.Parse(str2[2].ToString());
        
        int num = num2-num1+1;
        // total 
        int t = num*num*num*num;
        
        //3 same
        int three = 4*num*(num-1);
        int four = num;
        int total = t -(three+four);
        
         int v = dis*c*total;
        
        Console.WriteLine(v);
        //Console.WriteLine("Total: {0} dis:{1}, c:{2}, num:{3}",v,dis,c,num);
         //Console.WriteLine("t: {0}, three:{1}, four:{2},total: {3}",t,three,four,total);
    }
}

/*
Input1:
1
A B
0 1

Outout1:
24

Input2:
2
A C
1 2

Output2:
108
*/