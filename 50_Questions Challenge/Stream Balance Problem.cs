using System.IO;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //N : incoming pipes
        //M : Outgoing pipes
        // N M R
        // N items incoming pipes
        // M items ougoing pipes
        
        string str = Console.ReadLine();
        string[] s = str.Split();
        
        int N = Int32.Parse(s[0]);
        int M = Int32.Parse(s[1]);
        int R = Int32.Parse(s[2]);
        
        string ipstr = Console.ReadLine();
        string opstr = Console.ReadLine();
        
        string[] ip = ipstr.Split();
        string[] op = opstr.Split();
         
        List<int> inputs = new List<int>();
        List<int> outputs = new List<int>();
        
        for(int i=0;i<N;i++){
            int val = Int32.Parse(ip[i]);
            inputs.Add(val-R);
        }
        
        for(int i=0;i<M;i++){
            int val = Int32.Parse(op[i]);
            outputs.Add(val-R);
        }
        
        int input = 0;
        int output = 0;
        foreach(var v in inputs){
            input+=v;
        }
        
        foreach(var v2 in outputs){
            output+=v2;
        }
        
        if(input<output){
            Console.WriteLine((output-input)+R);
        }
        else if(output<input){
            Console.WriteLine(((input-output)+R)*(-1));
        }
        else{
            Console.WriteLine("BALANCED");
        }
        
        //Console.WriteLine("Hello, World!");
    }
}

/*

Input 1:
3 3 2
85 75 95
70 80 45

Output 2:
-62

Input 2:
5 6 1
10 26 33 40 50
20 7 53 25 45 10

Output 2:
Balanced

*/