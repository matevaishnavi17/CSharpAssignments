using System;
namespace Assignment3Of3
{
    internal class StackException<T>
    {
        int[] stack;
        int sp;
        public StackException()
        {

        }
        public bool Push(int value)
        {
            if (sp < stack.Length)
            {
                stack[sp] = value;
                sp++;
                return true;
            }
            else
            {
                throw new Exception("Stack is Full");
            }
        }
        public int Pop()
        {
            if (sp > 0)
            {
                sp--;
                return stack[sp];
            }
            else
            {
                throw new Exception("Stack is Empty");
            }
        }
    }
}