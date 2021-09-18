using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace myapp
{
    class Program
    {
      public static void Main(){
          int N = Int32.Parse(Console.ReadLine());
      int[] Nums = new int[N];

      for(int i=0;i<N;i++){
          Nums[i]=Int32.Parse(Console.ReadLine());
          }

      Array.Sort(Nums);
      int k = Int32.Parse(Console.ReadLine());
      for(int i=1;i<=N;i++){
          if(i==k){
              Console.WriteLine(Nums[i-1]);
          break;
          }
      }
      }
    }
}
