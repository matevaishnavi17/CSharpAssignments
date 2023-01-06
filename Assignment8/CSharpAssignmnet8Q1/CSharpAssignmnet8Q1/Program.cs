using System;
using System.Reflection;

namespace CSharpAssignment8Q1
{
    public class Example
    {
        public int add(string a, string b)
        {
            int res = Convert.ToInt32(a) + Convert.ToInt32(b);
            return res;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            Type exampleType = executingAssembly.GetType("CSharpAssignment8Q1.Example");//

            object exampleInstance = Activator.CreateInstance(exampleType);//object creation

            MethodInfo addNum = exampleType.GetMethod("add");// type of method

            string[] values = new string[2];
            values[0] = "2";
            values[1] = "7";

            Console.WriteLine($"Type: {exampleType}");
            MethodInfo[] methods = exampleType.GetMethods();
            Console.WriteLine("-----Methods Info-----");
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + "  " + method.Name);
            }

            int res = (int)addNum.Invoke(exampleInstance, values);//
            Console.WriteLine($"Result = {res}");
        }
    }
}
