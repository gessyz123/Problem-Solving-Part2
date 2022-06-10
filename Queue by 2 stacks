using System;
using System.Collections;

namespace ImplementStackWithQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack1 stack = new Stack1();
            stack.push(1);
            stack.push(2);
            stack.push(3);
            stack.push(4);
            stack.push(5);

            Console.WriteLine(stack.pop());
            Console.WriteLine(stack.pop());

        }
        class Stack1
        {
            Queue q1 = new Queue();
            Queue q2 = new Queue();

            public bool IsEmpty()
            {
                if (q1.Count == 0 && q2.Count == 0)
                    return true;
                return false;

            }

            public void push(int data)
            {
               
                q1.Enqueue(data);
            }
            public int pop()
            
            {
                if (q1.Count == 0)
                    throw new InvalidOperationException("No data to pop!");
                else
                {
                    while (q1.Count > 1)
                    {
                        q2.Enqueue(q1.Dequeue());
                      
                    }
                    int value = (int)q1.Dequeue();

                    Queue temp = q1;
                    q1 = q2;
                    q2 = temp;
                    return value;
                    
                }
         
            }

        }

    }
}
