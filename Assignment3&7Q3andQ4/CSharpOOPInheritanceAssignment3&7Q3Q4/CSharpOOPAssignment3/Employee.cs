using System;

namespace CSharpOOPAssignment3
{
	[Serializable]
    class Employee
    {
		public  int EmpNo;
		public string EmpName;
		public double Salary;
		public double HRA;
		public double TA;
		public double DA;
		public double PF;
		public double TDS;
		public double NetSalary;
		public double GrossSalary;

		

		public Employee(int EmpNo,string EmpName,double Salary)
		{
			this.EmpNo = EmpNo;
			this.EmpName = EmpName;
			this.Salary = Salary;
			

		}
		public void read()
		{
			Console.WriteLine("Enter Employee Number:");
			EmpNo = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Employee Name:");
			EmpName = Console.ReadLine();
			Console.WriteLine("Enter Employee Salary:");
			Salary = Convert.ToDouble(Console.ReadLine());
		}

		public double GrossCalculate()
		{

			if (Salary < 5000)
			{
				HRA = 10 * Salary / 100;
				TA = 5 * Salary / 100;
				DA = 15 * Salary / 100;
				GrossSalary = Salary + HRA + TA + DA;
			}
			else if (Salary < 10000)
			{
				HRA = 15 * Salary / 100;
				TA = 10 * Salary / 100;
				DA = 20 * Salary / 100;
				GrossSalary = Salary + HRA + TA + DA;
			}
			else if (Salary < 15000)
			{
				HRA = 20 * Salary / 100;
				TA = 15 * Salary / 100;
				DA = 25 * Salary / 100;
				GrossSalary = Salary + HRA + TA + DA;
			}
			else if (Salary < 20000)
			{
				HRA = 25 * Salary / 100;
				TA = 20 * Salary / 100;
				DA = 30 * Salary / 100;
				GrossSalary = Salary + HRA + TA + DA;
			}
			else if (Salary >= 20000)
			{
				HRA = 30 * Salary / 100;
				TA = 25 * Salary / 100;
				DA = 35 * Salary / 100;
				GrossSalary = Salary + HRA + TA + DA;
			}
			
			

			return GrossSalary;
		}
		public virtual void CalculateSalary()
        {
			PF = 10 * GrossSalary / 100;
			TDS = 18 * GrossSalary / 100;
			NetSalary = GrossSalary - (PF + TDS);
		}

		public void Display()
		{
			Console.WriteLine("Employee Number:" + EmpNo);
			Console.WriteLine("Employee Name:" + EmpName);
			Console.WriteLine("Employee Salary:" + Salary);
			Console.WriteLine("GrossSalary:" + GrossCalculate());
			

		}
	}

}



