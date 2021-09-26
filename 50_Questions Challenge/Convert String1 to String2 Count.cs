using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

class MyClass{
    public static void Main(){
        //length match
        string str1 = "convert";
        string str2 = "contact";
        
        Dictionary<char,int> d2 = new Dictionary<char,int>();
       
       int c = 0;
        
        for(int i=0;i<str2.Length;i++){
            if(d2.ContainsKey(str2[i])){
                d2[str2[i]]+=1;
            }
            else{
                d2[str2[i]] = 1;
            }
        }
        
        /*
        foreach(var v in d2){
            Console.WriteLine($"{v.Key} : {v.Value}");
        }
        */
        
        for(int i=0;i<str1.Length;i++){
            if(!str2.Contains(str1[i])){
                c++;
            }
            else{
                if(d2[str1[i]]<=0){
                    c+=1;
                }
                else{
                d2[str1[i]]-=1;
                }
            }
        }
        
        Console.WriteLine(c);
    }
}