using System;


public class Prog
{
    public static void Main(){
       int[] nums = new int[]{32,46,12,2,56,90,14,22,132,6};
       
       Array.Sort(nums);
       foreach(var v in nums){
           Console.Write(v+ " ");
       }
    }

}

/*
Output:
2 6 12 14 22 32 46 56 90 132

Overload Methods:
using System;
Array.Sort(array,index,length);
Array.Sort(array);

*/