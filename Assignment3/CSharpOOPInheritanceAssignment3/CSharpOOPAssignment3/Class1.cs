using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOPAssignment3
{
    class Program
    {
        public static void Main(String [] args)
        {
            Employee emp = new Employee(100,"Vaish",7000);
            emp.Display();
            Manager m = new Manager(12, "Hritik", 12000);
            m.Display();
        }
    }
}
