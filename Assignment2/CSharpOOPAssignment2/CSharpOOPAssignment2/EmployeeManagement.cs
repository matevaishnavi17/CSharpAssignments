using System;

namespace CSharpOOPAssignment2
{

	class Employee
	{
		private int EmpNo;
		private string EmpName;
		private double Salary;
		private double HRA;
		private double TA;
		private double DA;
		private double PF;
		private double TDS;
		private double NetSalary;
		private double GrossSalary;

		public int EMPNO { get; set; }
		public string EMPNAME { get; set; }
		public double SALARY { get; set; }
		public double HRA1 { get; set; }
		public double TA1 { get; set; }
		public double DA1 { get; set; }
		public double PF1 { get; set; }
		public double TDS1{get;set;}
		public double NETSALARY { get; set; }
		public double GROSSSALARY { get; set; }

		//countructor
		public Employee()
        {
			this.EMPNO = EmpNo;
			this.EMPNAME = EmpName;
			this.SALARY = Salary;
			this.HRA1 = HRA;
			this.TA1 = TA;
			this.DA1 = DA;
			this.PF1 = PF;
			this.TDS1 = TDS;
			this.NETSALARY = NetSalary;
			this.GROSSSALARY = GrossSalary;

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

		public double CalculateSalary()
        {
            
            if (Salary < 5000)
			{
				HRA = 10 * Salary / 100;
				TA = 5 * Salary / 100;
				DA = 15 * Salary / 100;
			}
			else if (Salary < 10000)
            {
				HRA = 15 * Salary / 100;
				TA = 10 * Salary / 100;
				DA = 20 * Salary / 100;
			}
			else if (Salary < 15000)
            {
				HRA = 20 * Salary / 100;
				TA = 15 * Salary / 100;
				DA = 25 * Salary / 100;
			}
			else if (Salary < 20000)
            {
				HRA = 25 * Salary / 100;
				TA = 20 * Salary / 100;
				DA = 30 * Salary / 100;
			}
			else if (Salary >= 20000)
            {
				HRA = 30 * Salary / 100;
				TA = 25 * Salary / 100;
				DA = 35 * Salary / 100;
			}
			GrossSalary = Salary + HRA + TA + DA;
			PF = 10 * GrossSalary / 100;
			TDS = 18 * GrossSalary / 100;
			NetSalary = GrossSalary - (PF + TDS);

			return GrossSalary;
        }

		public void Display()
        {
			Console.WriteLine("Employee Number:"+ EmpNo);
			Console.WriteLine("Employee Name:"+ EmpName);
			Console.WriteLine("Employee Salary:"+ Salary);
			Console.WriteLine("GrossSalary:"+ CalculateSalary());
			Console.WriteLine("NetSalary:" + NetSalary);

        }
	}

	class Program
    {
		public static void Main(string [] args)
        {
			Employee e = new Employee();
			e.read();
			//e.CalculateSalary();
			e.Display();
        }
    }

    
}
