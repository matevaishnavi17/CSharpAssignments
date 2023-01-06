using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CSharpOOPAssignment3
{
    class Program
    {
        public static void SerializeObject(Object o)
        {
            FileStream fs = new FileStream(@"C:\Users\VGANESHM\source\repos\CSharpOOPInheritanceAssignment3\output.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, o);
            fs.Close();
        }

        public static void DeserializeObject()
        {
            FileStream fs = new FileStream(@"C:\Users\VGANESHM\source\repos\CSharpOOPInheritanceAssignment3\output.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Manager m1 = new Manager(12,"sasasa",396565);
            m1 = (Manager)formatter.Deserialize(fs);
            Console.WriteLine($"-----Printing DeSerialized Manager Object-----\n{m1}");
            fs.Close();
        }
        public static void Main(String [] args)
        {
            Employee emp = new Employee(100,"Vaish",7000);
            emp.Display();
            Manager m1 = new Manager(12, "Hritik", 12000);
            m1.Display();
            SerializeObject(m1);
            DeserializeObject();
        }
    }
}
