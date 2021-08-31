using System.IO;
using System.Collections.Generic;
using System;

class Program
{
    static void Main()
    {
        int m = Int32.Parse(Console.ReadLine());
        int n = Int32.Parse(Console.ReadLine());
        //m = 3; 
        //n = 3;
        int[,] arr = new int[m,n]; 
        int num = 1;
      for(int p = 0 ; p < m ; p++){
          for(int k = 0 ; k < n; k++){
              arr[p,k] = num;
              num+=1;
          }
      }
      
        int i = 0,j = 0;
        
        for(int v=0;v<m*n;){
            while(j<n){
                Console.WriteLine(arr[i,j]);
                v+=1;
                j+=1;
            }
            j-=1;
            i+=1;
            while(i<m){
                Console.WriteLine(arr[i,j]);
                v+=1;
                i+=1;
            }
            j-=1;
            i-=1;
            while(j>=0){
                Console.WriteLine(arr[i,j]);
                v+=1;
                j-=1;
            }
            i-=1;
            j+=1;
            while(i>=0){
                Console.WriteLine(arr[i,j]);
                v+=1;
                i-=1;
            }
        }
        
    /*
    
    for(int i=0;i<m;i++){
        for(int j=0;j<n;j++){
             Console.WriteLine(arr[i,j]);
        }
    }
    
    */
        Console.WriteLine("Hello, World!");
    }
}