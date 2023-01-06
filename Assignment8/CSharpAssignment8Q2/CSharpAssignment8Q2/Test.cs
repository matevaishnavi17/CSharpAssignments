using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CSharpAssignment8Q2
{
    public class Test
    {
        public void ReadAttributes()
        {
            Attribute[] attrs1 = Attribute.GetCustomAttributes(typeof(HDFCAccount));
            Attribute[] attrs2 = Attribute.GetCustomAttributes(typeof(ICICIAccount));

            Console.WriteLine("-----FOR HDFC ACCOUNT CLASS-----");
            foreach (Attribute attr in attrs1)
            {
                Console.WriteLine($"ATTRIBUTE APPLIED ON THIS CLASS : {attr}");
                Type t = attr.GetType();
                MethodInfo[] methods = t.GetMethods();
                PropertyInfo[] properties = t.GetProperties();
                Console.WriteLine("-----METHODS INFO-----");
                foreach (MethodInfo m in methods)
                {
                    Console.WriteLine(m.ReturnType.Name + " " + m.Name);
                }
                Console.WriteLine("-----PROPERTIES INFO-----");
                foreach (PropertyInfo p in properties)
                {
                    Console.WriteLine(p.PropertyType.Name + " " + p.Name);
                }
            }
            Console.WriteLine("-----FOR ICICI ACCOUNT CLASS-----");
            foreach (Attribute attr in attrs2)
            {
                Console.WriteLine($"ATTRIBUTE APPLIED ON THIS CLASS : {attr}");
                Type t = attr.GetType();
                MethodInfo[] methods = t.GetMethods();
                PropertyInfo[] properties = t.GetProperties();
                Console.WriteLine("-----METHODS INFO-----");
                foreach (MethodInfo m in methods)
                {
                    Console.WriteLine(m.ReturnType.Name + " " + m.Name);
                }
                Console.WriteLine("-----PROPERTIES INFO-----");
                foreach (PropertyInfo p in properties)
                {
                    Console.WriteLine(p.PropertyType.Name + " " + p.Name);
                }
            }

        }
    }
}
