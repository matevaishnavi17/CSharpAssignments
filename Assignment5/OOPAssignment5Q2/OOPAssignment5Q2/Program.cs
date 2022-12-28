
using System;
using System.Collections;
namespace OOPAssignment5Q2
{
    internal class Employee
    {


        public int ID { get; set; }
        public string Name;
        public double Salary;
        public static int EmployeeCount = 0;//static member variable

        //default constructor
        public Employee()
        {
            ID = 0;
            Name = "";
           
            Salary = 0.0;
            EmployeeCount += 1;
        }
        //Parameterized constructor
        public Employee(int id, string name, double salary)
        {
            this.ID = id;
            this.Name = name;
            
            this.Salary = salary;
            EmployeeCount += 1;
        }
        public override string ToString()
        {
            return "\nEmployee Id = " + ID + "\nEmployee Name = " + Name + "\nBasic Salary = " + Salary;
        }


        //Salary calculation 
        public virtual double CalculateSalary()
        {
            return Salary;
        }
    }
    class MainClass
    {
        public static void DisplayArrayList(string arrayListName, ArrayList myArrayList)
        {
            for (int i = 0; i < myArrayList.Count; i++)
            {
                Console.WriteLine(arrayListName + "[" + i + "] = " + myArrayList[i]);
            }
        }

        class Program
        {
            public static void Main()
            {
                Employee emp = new Employee(100, "Vaishnavi", 20000);
                Employee emp1 = new Employee(100, "Hritik", 20000);
                ArrayList employee = new ArrayList();
                employee.Add(emp);
                employee.Add(emp1);
                DisplayArrayList("Employee", employee);

            }


        }
    }
}

