using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program{
    public static void Main(){
        int l = Int32.Parse(Console.ReadLine());
        int u = Int32.Parse(Console.ReadLine());
        
        int c = 0;
        for(int i=l;i<=u;i++){
            if(i<9){
                c++;
                //Console.WriteLine("Item: {0}",i);
            }
            else{
                bool v = Check(i);
                if(v){c+=1;}
            }
            
        }
        Console.WriteLine("Count: {0}",c);
    }
    
    static bool Check(int n){
        int r = n;
        List<int> items = new List<int>();
        while(n>0){
            int t = n%10;
            items.Add(t);
            n/=10;
        }
        
        items.Sort();
        
        for(int i=0;i<items.Count-1;i++){
            if(items[i]==items[i+1]) return false;
        }
        
        //Console.WriteLine("Item: {0}",r);
        
        return true;
    }
}

/*

Input: 
131
145

Output: 
11

*/