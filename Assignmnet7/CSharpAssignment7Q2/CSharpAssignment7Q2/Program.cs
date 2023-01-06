using System;
using System.IO;

namespace CSharpAssignment7Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\VGANESHM\source\repos\CSharpAssignment7Q2\CSharpAssignment7Q2\Text.txt";
            Console.WriteLine("Enter Customer Details....");
            Console.WriteLine("Enter Account Number:");
            int Acc_Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer Name:");
            string Customer_Name = Console.ReadLine();
            Console.WriteLine("Enter Balance:");
            int Balance = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter writer = new StreamWriter(path))//for displaying output on console
            {
                writer.Write("Customer Name:" + Customer_Name + "\nAccount Number:" + Acc_Number + "\nBalance:" + Balance);
            }
            Console.WriteLine("Saved");



            Console.WriteLine("\n\nReading Text File:::");

            using (StreamReader reader = new StreamReader(path))//for storing output in file
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}

