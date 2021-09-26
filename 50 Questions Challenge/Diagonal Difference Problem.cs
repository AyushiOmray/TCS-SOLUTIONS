using System.IO;
using System;

class Program
{
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        string str = Console.ReadLine();
        string[] s = str.Split();
        
        int[,] arr = new int[n,n];
        int k = 0;
        for(int i=0;i<n;i++){
            for(int j=0;j<n;j++){
                arr[i,j] = Int32.Parse(s[k]); 
                k+=1;
            }
        }
        
        //LOGIC
        int s1 = 0,s2 = 0;
        for(int i=0;i<n;i++){
            for(int j=0;j<n;j++){
                if(i==j){
                    s1+=arr[i,j];
                    
                }
                
                if((i+j+1)==n){
                    s2+=arr[i,j];}
                }
        }
        
        Console.WriteLine("S1: {0} S2: {1} Ans: {2}",s1,s2,Math.Abs(s1-s2));
    }
}