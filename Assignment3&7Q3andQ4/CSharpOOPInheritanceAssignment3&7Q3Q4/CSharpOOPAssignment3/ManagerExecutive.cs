using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOPAssignment3
{
    [Serializable]
    class ManagerExecutive:Employee,Interface1
    {
        double Kilometer_Travel;
        double TourAllowance;
        double TelephoneAllowance;
        double GrossSalary;
        public ManagerExecutive(int EmpNo,string EmpName,double Salary):base(EmpNo,EmpName,Salary)
        {
            
        }

        public void ManagerExecutiveGrossSalary()
        {
            Console.WriteLine("Enter Kilometer Travel:");
            Kilometer_Travel = Convert.ToDouble(Console.ReadLine());
            TourAllowance = 5 * Kilometer_Travel;
            TelephoneAllowance = 1000;
            GrossSalary = Salary + HRA + TA + DA + TelephoneAllowance + TourAllowance;
            Console.WriteLine("GrossSalary is: " + GrossSalary);
        }
        public override void CalculateSalary()
        {
            base.CalculateSalary();

        }

        public new void Display()
        {
            base.Display();
        }
    }
}
