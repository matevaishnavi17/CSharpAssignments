using System;

namespace CSharpAssignment5Q4
{
    class MyStack<T>
    {
        int capacity;
        T[] stack;
        int top;

        public MyStack(int MaxElements)

        {

            capacity = MaxElements;

            stack = new T[capacity];

            //initialize top with -1

        }

        public int push(T Element)

        {

            //Check Overflow

            if (top == capacity - 1)

            {

                // return -1 if over flow is there

                return -1;

            }

            else

            {

                // insert elementt into stack

                top = top + 1;

                stack[top] = Element;

            }

            return 0;

        }

        public T pop()

        {

            T RemovedElement;

            T temp = default(T);

            //check Underflow

            if (!(top <= 0))

            {

                RemovedElement = stack[top];

                top = top - 1;

                return RemovedElement;

            }

            return temp;



        }


        public T peep(int position)

        {

            T temp = default(T);

            //check if Position is Valid or not

            if (position < capacity && position >= 0)

            {

                return stack[position];

            }

            return temp;

        }

        public T[] GetAllStackElements()

        {

            T[] Elements = new T[top + 1];

            Array.Copy(stack, 0, Elements, 0, top + 1);

            return Elements;

        }

    }

    class Program
    {


        public static void Main(string[] args)

        {

            int capacity;
            Console.WriteLine("Enter Capacity of Stack :");
            capacity = int.Parse(Console.ReadLine());
            MyStack<string> stack = new MyStack<string>(10);
            while (true)

            {

                Console.WriteLine("1.Push");
                Console.WriteLine("2.Pop");
                //Console.WriteLine("3.Peep");
                Console.WriteLine("4.Print Stack Elements:");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Eneter your Choice :");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)

                {
                    case 1:

                        {

                            Console.WriteLine("Enter String to Push :");

                            string temp = Console.ReadLine();

                            int result = stack.push(temp);

                            if (result != -1)

                            {

                                Console.WriteLine("Element Pushed into Stack !");

                            }

                            else

                            {

                                Console.WriteLine("Stack Overflow !");

                            }

                            break;

                        }

                    case 2:

                        {

                            string Result = stack.pop();

                            if (Result != null)

                            {

                                Console.WriteLine("Delete Element :" + Result);

                            }

                            else

                            {

                                Console.WriteLine("Stack Underflow !");

                            }

                            break;

                        }



                    /*case 3:

                        {

                            Console.WriteLine("Enter Position of Element to Pop:");

                            int Position = int.Parse(Console.ReadLine());

                            string Result = stack.peep(Position);



                            if (Result != null)

                            {

                                Console.WriteLine("Element at Position" + Position + " is " + Result);

                            }

                            else

                            {

                                Console.WriteLine("Entered Element is Out of Stack Range ");

                            }

                            break;

                        }*/

                    case 3:

                        {

                            string[] Elements = stack.GetAllStackElements();

                            Console.WriteLine("**************Stack Content **************");

                            foreach (string str in Elements)

                            {

                                Console.WriteLine(str);

                            }

                            break;

                        }

                    case 4:

                        {

                            System.Diagnostics.Process.GetCurrentProcess().Kill();

                            break;

                        }

                    default:

                        {

                            Console.WriteLine("You have Entered Wrong Choice ");

                            break;

                        }

                }

            }

        }
    }
}
