using System;
using System.Collections.Generic;

namespace NGE__Next_Gretaer_Element_
{
    class Program
    {
        public class Stack
        {
            
        }
        static void Main(string[] args)
        {
            int[] arr = {20,13,4,1 };
            //NextGreaterElement(arr);
            int[] NGE = new int[arr.Length];
            NextGreaterElement2(arr);
           

        }

        public static void NextGreaterElement2(int[] nums)
        {
            int pointer = 0;
            int[] NGE = new int[nums.Length];
            Stack<int> stack = new Stack<int>();
            stack.Push(nums[0]);

            for (int i = 1; i <nums.Length; i++)
            {
                if (stack.Count > 0)
                { 
                    while (stack.Count > 0 && nums[i] >= stack.Peek())
                    {

                        NGE[pointer] = nums[i];
                        pointer++;
                        stack.Pop();

                    }
                    stack.Push(nums[i]);

                }

                }
       
          //  Console.WriteLine("pointer" + pointer);
            if(pointer< NGE.Length)
            
           {
                for(int j= pointer; j<NGE.Length; j++) 
                NGE[j] = -1;
               
            }

            for (int i = 0; i < NGE.Length; i++)
            {
                Console.WriteLine (NGE[i]);
            }
        }
        public static void NextGreaterElement(int[] nums)
        {
            int current=0;
            Console.Write("NGE are : ");
            for (int i = 0; i < nums.Length; i++)
            {
                current = i + 1;
                if(current< nums.Length)
                {
                    if (nums[i] < nums[current])
                        Console.Write(nums[current] + " ");
                    else
                        current++;
                }
                
            }

            Console.Write("-1");

         
        }
    }
}
