using System;

namespace CsharpAssignment3Q2
{
    public class StackException : Exception
    {
        public StackException(string message) : base(message) { }//constructor of user defined exception
    }
    class MyStack : ICloneable
    {
        private int[] arr = new int[20];
        private int top = -1;
        private int size;

        public object Clone()
        {
            MyStack m = new MyStack
            {
                arr = this.arr,
                top=this.top,
                size=this.size
            };
            return m;
        }
        public int SIZE { get
            {
                return SIZE;
            }
            set
            {
                this.size = arr.Length;
            }
        }

        public void push(int a)
        {
            try
            {
                if (top == arr.Length - 1)
                {
                    throw new StackException("Stack is Full");
                }
                arr[++top] = a;
                Console.WriteLine("Pushed" + a + "on to the stack");
            }
            catch(StackException st)
            {
                Console.WriteLine(st);
            }
        }

        public void pop()
        {
            try
            {
                if (top == -1)
                {
                    throw new StackException("Stack id Empty");
                }
                Console.WriteLine(arr[top] + "popped");
                arr[top--] = 0;
            }
            catch(StackException st)
            {
                Console.WriteLine(st);
            }
        }

        public void display()
        {
            Console.WriteLine("Items in stack:");
            foreach(int i in arr)
            {
                Console.Write(i + " \n");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            MyStack ms = new MyStack();

            do
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1.Push\n 2.Pop \n 3.Display \n 4.Clone \n 5.Exit");
                n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.WriteLine("Enter Element");
                        int num = Convert.ToInt32(Console.ReadLine());
                        ms.push(num);
                        break;
                    case 2:
                        ms.pop();
                        break;
                    case 3:
                        ms.display();
                        break;
                    case 4:
                        MyStack m = ms.Clone() as MyStack;
                        m.display();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Enter Valid Choice");
                        break;

                }

            } while (n!=5);
        }
    }
}
