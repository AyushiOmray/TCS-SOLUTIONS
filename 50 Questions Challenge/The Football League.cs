using System.IO;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //win -> 3 draw -> 1 loss -> 0
        //Inputs:
        //1. No of teams (N)
        // next N*(N-1)/2 Lines have values of form (string)<Team1, Team2, Score(M-N)> A B 2-1
        
        int N = Int32.Parse(Console.ReadLine());
        int limit = (N*(N-1))/2;
        string[] data = new string[limit];
        
        for(int i=0;i<limit;i++){
            data[i] = Console.ReadLine();
        }
        
        Dictionary<string,int> scores = new Dictionary<string, int>();
        
        for(int i=0;i<limit;i++){
            int val = 65+i;
            string c = ((char)val).ToString();
           // Console.WriteLine(c);
            scores[c] = 0;
        }
        
        foreach(var d in data){
            string[] str = d.Split();
            
            string team1 = str[0];
            string team2 = str[1];
            
            string[] score = str[2].Split(new char[]{'-'});
            
            int s1 = Int32.Parse(score[0]);
            int s2 = Int32.Parse(score[1]);
            
            //Console.WriteLine(team1);
            //Console.WriteLine(team2);
            
            if(s1>s2){
                scores[team1] += 3; 
            }
            else if(s2>s1){
                scores[team2] +=3;
            }
            else if(s1==s2){
                scores[team1]+=1;
                scores[team2]+=1;
            }
        }
        
        int max = 0;
        string winner = "";
        foreach(var v in scores){
            if(v.Value>=max){
                max = v.Value;
                winner = v.Key;
            }
        }
        
        Console.WriteLine("Winner Team : {0} and their score is : {1}", winner, max);
    }
}

/* Inputs
3
A B 2-1
B C 5-6
C A 2-1
*/