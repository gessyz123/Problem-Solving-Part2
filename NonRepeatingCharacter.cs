using System;
using System.Collections.Generic;

namespace firstNonRepeatingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] stream = { 'a' , 'a', 'b' , 'c'};
            NonRepeatingChar(stream);


        }

        public static void NonRepeatingChar(char[] stream)
        {
            Dictionary<char, int> freq = new Dictionary <char,int>();
            Queue<char>q = new Queue<char>();

            if (stream.Length == 0)
                throw new InvalidOperationException("Empty Stream");

            for (int i = 0; i < stream.Length; i++)
            {

                if (freq.ContainsKey(stream[i]))
                {
                    freq[stream[i]]++;
                    q.Dequeue();
                   
                       
                }
                else
                {
                    freq.Add(stream[i], 1);
                    q.Enqueue(stream[i]);
                    

                }
                if (q.Count == 0)
                    Console.Write(-1 + " ");
                else
                    Console.Write(q.Peek() + " ");
            }


                    

        }

    }
}
