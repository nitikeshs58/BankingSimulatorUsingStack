using System;

namespace BankingSimulatorStack
{
    class StackList
    {
        // Array declaration
        int[] stackListArray;

        //initialising variables
        int top = 0;
        int size;

        /// <StackList>
        /// Defined parameterized Constructor.
        /// initialised array size 
        /// initialised 0 with rear and front.
        /// </StackList>
        public StackList(int capacity)
        {
            size = capacity;
            stackListArray = new int[size];
        }

        /// <push>
        ///inserting values
        ///inseting values in array using index "top"
        ///then incrementing top
        /// </push>
        public void push(int data)
        {
            if (top == size)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                stackListArray[top++] = data;
            }
        }

        /// <pop>
        ///removing values
        ///decrementing 'top' so user will be removed
        /// </pop>
        public void pop()
        {
            if (top == 0)
            {
                Console.WriteLine("Stack is empty.");
            }
            else
            {
                top--;
            }
        }

        // to display StackList
        public void showStacklist()
        {
            for (int i = 0; i < top; i++)
            {
                Console.WriteLine("Current Balance: " + stackListArray[i]);
            }
        }
    }
}

