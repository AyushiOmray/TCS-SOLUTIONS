using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            //abcde

            //Forward
            sb1.Append(s[s.Length-1]);
            for(int i = 0;i<s.Length-1;i++){
                sb1.Append(s[i]);
            }

            for(int i=1;i<s.Length;i++){
                sb2.Append(s[i]);
            }

            sb2.Append(s[0]);

            if(sb1.ToString().Equals(sb2.ToString())){
                Console.WriteLine("Yes");
            }
            else{
                Console.WriteLine("No");
            }
           
        }
    }
}
