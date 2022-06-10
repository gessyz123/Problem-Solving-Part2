  class MinStack
        {
            Stack stack;
            int minimum;

            public MinStack()
            {
                stack = new Stack();
                minimum = -1;
            }

            public void Push(int data)
            {
                if (stack.Count == 0 ) 
                {
                    minimum = data;
                    stack.Push(data);
                }


                if (data < minimum)
                {
                    int value = 2 * data - minimum;
                    stack.Push(value);
                    minimum = data;
                }
                else
                    stack.Push(data);
            }

            public int Pop()
            {
                if (stack.Count == 0)
                    throw new InvalidOperationException("Stack is empty!");
                else
                {
                    int value=  (int)stack.Peek();
                    if (value < minimum)
                    {
                        int pop = minimum;
                        minimum = 2 * minimum - value;
                        stack.Pop();
                        return pop;

                    }
                    else
                        return (int)stack.Pop();
                }  
            }

            public int getMin()
            {
                return minimum;
            }
        }


    }
