using System;

namespace Assignment3Of3
{
    
    class Program
    {
        static void Main(string[] args)
        {
            StackException <int>st = new StackException <int>();
            st.Push(1);
            st.Push(2);
            st.Push(3);

            st.Pop();

            //(Object i in st)
            //{
             //   Console.WriteLine(i);
           // }
            //Console.ReadKey();
        }
    }
}
