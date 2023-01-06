using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOPAssignment3
{
    [Serializable]
    class Manager : Employee, Interface1
    {
        double PetrolAllowance;
        double FoodAllowance;
        double OtherAllowance;
        double grosssalary;
        public Manager(int EmpNo, string EmpName, double Salary) : base(EmpNo, EmpName, Salary)
        {

        }
        
        public double ManagerGrossSalary()
        {
            PetrolAllowance = (Salary * 8) / 100;
            FoodAllowance = (Salary * 13) / 100;
            OtherAllowance = (Salary * 3) / 100;
            grosssalary = Salary + HRA + TA + DA + PetrolAllowance + FoodAllowance + OtherAllowance;
            return grosssalary;
        }

        public override void CalculateSalary()
        {
            base.CalculateSalary();

        }

        public new void Display()
        {
            Console.WriteLine("The Employee Id is: " +EmpNo);
            Console.WriteLine("The Employee Name is: " +EmpName);
            Console.WriteLine("The Employee Salary is: " +Salary);
            Console.WriteLine("GrossSalary:" + ManagerGrossSalary());
        }


    }
	
}

