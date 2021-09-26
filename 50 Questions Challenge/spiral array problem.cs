using System.IO;
using System;

class Program
{
    static void Main()
    {
        int m = Int32.Parse(Console.ReadLine());
        int n = Int32.Parse(Console.ReadLine());
        
        int[,] arr = new int[m,n];
        
        int num = 1;
        
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                arr[i,j]=num;
                num+=1;
            }
        }
        
        //LOGIC
        int si = 0, sj=0;
        int ei = m-1, ej=n-1;
        num = 0;
        while(num<=m*n){
            for(int j=sj;j<=ej;j++){
                Console.WriteLine(arr[si,j]);
                num+=1;
            }
            si+=1;
            
            if(num==m*n) break;
            for(int i=si;i<=ei;i++){
                Console.WriteLine(arr[i,ej]);
                num+=1;
            }
            ej-=1;
            
            if(num==m*n) break;
            
            for(int j=ej;j>=sj;j--){
                Console.WriteLine(arr[ei,j]);
                num+=1;
            }
            ei-=1;
            
            if(num==m*n) break;
            
            for(int i=ei;i>=si;i--){
                //Console.WriteLine("Here");
                Console.WriteLine(arr[i,sj]);
                num+=1;
            }
            sj+=1;
            
            if(num==m*n) break;
            
        }
        Console.WriteLine("Hello, World!");
    }
}