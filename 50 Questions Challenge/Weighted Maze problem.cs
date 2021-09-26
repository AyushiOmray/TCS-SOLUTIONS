using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        //N no of rows and cols
        // N lines representing the weight from left to right
        //Output -> min weight possible in the cart
        
        int N = Int32.Parse(Console.ReadLine());
        int[,] maze = new int[N,N];
        List<int> nums = new List<int>();
        
        for(int k=0;k<N;k++){
            string str = Console.ReadLine();
            string[] s = str.Split();
            
            foreach(var v in s){
                nums.Add(Int32.Parse(v));
            }
        }
        
        int len = 0;
        
        for(int i=0;i<N;i++){
            for(int j=0;j<N;j++){
                maze[i,j] = nums[len];
                len+=1;
            }
        }
        
        int r = 0;
        int c = 0;
        int w = 1;
        string move;
        
        while(r!=N-1 || c!=N-1){
          if(c<N-1 && r<N-1){
              move = Min(maze[r,c+1],maze[r+1,c]);
              
              if(move == "r"){
                   c+=1;
                   w = Max(w,maze[r,c]);
                   //Console.WriteLine("Maze[{0},{1}]: {2}",r,c,w);
              }
              else{
                  r+=1;
                  w = Max(w,maze[r,c]);
                   //Console.WriteLine("Maze[{0},{1}]: {2}",r,c,w);
              }
          }
          else if(c==N-1){
              r+=1;
              w = Max(w,maze[r,c]);
               //Console.WriteLine("Maze[{0},{1}]: {2}",r,c,w);
          }
           else if(r==N-1){
              c+=1;
              w = Max(w,maze[r,c]);
               //Console.WriteLine("Maze[{0},{1}]: {2}",r,c,w);
          }
          
        }
        
        Console.WriteLine("Weight: {0}",w);
    }
    
    static string Min(int a,int b){
        if(a<=b){ return "r";} //right j+=1; 
        else {return "d";} //down i+=1;
    }
    
      static int Max(int a,int b){
        if(a>=b){ return a;} //right j+=1; 
        else {return b;} //down i+=1;
    }
}

/* 
Input: 
4
1 8 21 7
19 17 10 20
2 19 23 22
14 25 4 13

Output:
22

Input:
4
1 8 21 7
19 17 10 20
2 1 23 22
14 25 4 13

output:
3

*/