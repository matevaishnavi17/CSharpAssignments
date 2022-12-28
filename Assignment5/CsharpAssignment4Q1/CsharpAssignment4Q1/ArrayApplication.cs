using System;

namespace CsharpAssignment5Q1
{
   

    class program
    {
        public static void Main(string[] args)
        {
            int  i,ch;
            int[] arr1 = new int[5];
            int[] arr2 = new int[arr1.Length];
            string[] arr3 = new string[5];
            string[] arr4 = new string[arr3.Length];
            program a = new program();


             void PrintStrArray(string []str)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Array Elemnts:" + str[i]);
                }
                Console.WriteLine("\n");
            }
            void PrintIntArray(int [] n)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Array Elemnts:" + n[i]);
                }
                Console.WriteLine("\n");
            }

            //array1
            Console.WriteLine("\nEnter the Elemnts of Integer array  \n");
            for (i = 0; i < arr1.Length; i++)
            {
                
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            PrintIntArray(arr1);

            //array2
            Console.WriteLine("\nEnter the  Elemnts of String array  \n");
            for (i = 0; i < arr3.Length; i++)
            {
                arr3[i] = Console.ReadLine();
            }
            PrintStrArray(arr3);

            do
            {
                Console.WriteLine("enter your choice: \n 1.Sort Integer \n2.Sort String Array \n 3.Reverse Integer Array" +
                    "\n4.Reverse String Array\n5.Copy Integer Array \n6.Copy String array \n7.Clear Integer Array" +
                    "\n8.Clear String Array\n9.Exit");
                 ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Sorted Integer Array :");

                        Array.Sort(arr1);
                        PrintIntArray(arr1);
                        break;
                    case 2:
                        Console.WriteLine("Sorted String Array :");
                        Array.Sort(arr3);
                        PrintStrArray(arr3);
                        break;
                    case 3:
                        Console.WriteLine("Reverse Integer Array :");
                        Array.Reverse(arr1);
                        PrintIntArray(arr1);
                        break;
                    case 4:
                        Console.WriteLine("Reverse String Array :");
                        Array.Reverse(arr3);
                        PrintStrArray(arr3);
                        break;
                    case 5:
                        Console.WriteLine("Copy Integer Array :");
                        Array.Copy(arr1, arr2, arr1.Length);
                        PrintIntArray(arr2);
                        break;
                    case 6:
                        Console.WriteLine("Copy String Array :");
                        Array.Copy(arr3, arr4, arr3.Length);
                        PrintStrArray(arr4);
                        break;
                    case 7:
                        Console.WriteLine("Clear Integer Array1:\n");
                        Array.Clear(arr1, 0, arr1.Length);
                        PrintIntArray(arr1);
                        break;
                    case 8:
                        Console.WriteLine("Clear String Array3:\n");
                        Array.Clear(arr3, 0, arr3.Length);
                        PrintStrArray(arr3);
                        break;
                    case 9:
                        break;
                    default:
                        Console.WriteLine("Enter valid Choice");
                        break;
                }
            } 
            while (ch != 9);
          
        }

            

    }
}
