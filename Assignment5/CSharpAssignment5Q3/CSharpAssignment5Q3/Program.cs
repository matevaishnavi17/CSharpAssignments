using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAssignment5Q3
{
    class Employee
    {
        public int EMPID { get; set; }
        public string EMPNAME { get; set; }
        public double SALARY { get; set; }
        public string ROLE { get; set; }

        public Employee()
        {

        }

        public Employee(int empid, string empname, double salary, string role)
        {
            this.EMPID = empid;
            this.EMPNAME = empname;
            this.SALARY = salary;
            this.ROLE = role;
        }

        //List all Employee
        public void ListAllEmployee()
        {
            Console.WriteLine("\n\t" + EMPID + "\t" + EMPNAME + "\t\t" + SALARY + "\t" + ROLE);

        }

        //add new Employee
        public static List<Employee> Add_Employee(List<Employee> employee, Employee emp)
        {

            employee.Add(emp);
            return employee;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            int choice2 = 0;

            List<Employee> employee = new List<Employee>();
            employee.Add(new Employee(1, "Vaishnavi", 40000, "ore"));
            employee.Add(new Employee(2, "Hritik", 30000, "SAP"));
            employee.Add(new Employee(3, "Sharvari", 120000, ".NET"));
            employee.Add(new Employee(4, "Ayush", 120000, "AWS"));
            employee.Add(new Employee(5, "Tanvi", 21000, "CSI NETWORKING"));

            Console.WriteLine("1.List all Employee.\n 2.Add New Employee\n ");
            Console.Write("\nEnter Your Choice : ");
            string input = Console.ReadLine();

            while (true)
            {
                if (int.TryParse(input, out choice2))
                {
                    if (choice2.Equals(1))
                    {
                        Console.WriteLine("\t\t\t-------Empolyee Details-------");
                        Console.WriteLine("\n\tID \t Name \t\t Salary \tRole ");

                        employee.ForEach(p => p.ListAllEmployee());

                        Console.Write("\nEnter Your Choice : ");
                        input = Console.ReadLine();
                    }
                    else if (choice2.Equals(2))
                    {
                        Console.WriteLine("\n\t\t\t------- Add Empolyee -------");
                        Employee emp = new Employee();
                        Console.Write("Enter Empolyee ID : ");
                        int Emp_id = Convert.ToInt32(Console.ReadLine());
                        var empinfo = employee.Where(e => e.EMPID == Emp_id).FirstOrDefault();

                        if (empinfo == null)
                        {
                            empinfo = emp;
                            empinfo.EMPID = 0;
                        }

                        if (Emp_id != null)
                        {
                            if (empinfo.EMPID != Emp_id || empinfo.EMPID == null)
                            {
                                emp.EMPID = Emp_id;
                                Console.WriteLine("Enter Name:");
                                emp.EMPNAME = Console.ReadLine();
                                Console.WriteLine("Enter Salary:");
                                emp.SALARY = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Enter Role:");
                                emp.ROLE = Console.ReadLine();

                                employee.Where(e => e.EMPID == emp.EMPID);
                                employee.Where(e => e.EMPNAME == emp.EMPNAME);
                                employee.Where(e => e.SALARY == emp.SALARY);
                                employee.Where(e => e.ROLE == emp.ROLE);
                                employee.Add(emp);

                                Console.WriteLine("\n\tEmployee with id: " + Emp_id + " Added successfully");
                            }

                            else
                            {
                                Console.WriteLine("\n\tEmployee " + empinfo.EMPID + " Already Exist, Choice Again Options");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Employee with id: " + Emp_id + " does not exist");
                        }

                        Console.Write("\nEnter Your Choice : ");
                        input = Console.ReadLine();
                    }
                    /*else if (choice2.Equals(3))
                    {
                        Console.WriteLine("Eneter Employee Id to Search:");
                        int emp_id = Convert.ToInt32(Console.ReadLine());

                    }*/
                
                }
                else
                {
                    Console.WriteLine("Choice invaild, Try Again");
                    Console.Write("\nEnter Your Choice : ");
                    input = Console.ReadLine();
                }
            }
        }
    }
}