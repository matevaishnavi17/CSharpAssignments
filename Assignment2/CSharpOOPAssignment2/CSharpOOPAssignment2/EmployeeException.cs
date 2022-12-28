using System;

public class EmployeeException
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

	public int EMPNO
	{
		get { return EmpNo; }
		set
		{
			try
			{
				if (value < 0)
				{
					throw new Exception("Employee Id cannot be negative");
				}
				this.EmpNo = value;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				Environment.Exit(1);
			}
		}
	}
	public string EMPNAME
	{
		get { return EmpName; }
		set
		{
			try
			{
				if (String.IsNullOrEmpty(value))
				{
					throw new Exception("Employee name cannot be null");
				}
				this.EmpName = value;
			}
			catch (Exception e1)
			{
				Console.WriteLine(e1);
				Environment.Exit(1);
			}
		}
	}

	public double SALARY
	{
		get { return Salary; }
		set
		{
			try
			{
				if (value < 0)
				{
					throw new Exception("Salary can not be negative");
				}
				this.Salary = value;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				Environment.Exit(1);
			}
		}
	}

	public double GROSSSALARY
	{

		set
		{
			if (SALARY < 5000)
			{
				HRA = (SALARY * 10) / 100;
				TA = (SALARY * 5) / 100;
				DA = (SALARY * 15) / 10;
				GrossSalary = SALARY + HRA + TA + DA;
			}
			else if (SALARY < 10000)
			{
				HRA = (SALARY * 15) / 100;
				TA = (SALARY * 10) / 100;
				DA = (SALARY * 20) / 10;
				GrossSalary = SALARY + HRA + TA + DA;
			}
			else if (SALARY < 15000)
			{
				HRA = (SALARY * 20) / 100;
				TA = (SALARY * 15) / 100;
				DA = (SALARY * 25) / 10;
				GrossSalary = SALARY + HRA + TA + DA;
			}
			else if (SALARY < 20000)
			{
				HRA = (SALARY * 25) / 100;
				TA = (SALARY * 20) / 100;
				DA = (SALARY * 30) / 10;
				GrossSalary = SALARY + HRA + TA + DA;
			}
			else if (SALARY >= 20000)
			{
				HRA = (SALARY * 30) / 100;
				TA = (SALARY * 25) / 100;
				DA = (SALARY * 35) / 10;
				GrossSalary = SALARY + HRA + TA + DA;
			}
		}
		get { return GrossSalary; }

	}

	public void CalculateSalary()
	{
		PF = (GROSSSALARY * 10) / 100;
		TDS = (GROSSSALARY * 18) / 100;
		NetSalary = GROSSSALARY - (PF + TDS);
		Console.WriteLine("PF is:" + PF);
		Console.WriteLine("TDS is:" + TDS);
		Console.WriteLine("Net Salary is:" + NetSalary);
	}
	public EmployeeException(int empNo, string empName, double salary)
	{
		this.EMPNO = empNo;
		this.EMPNAME = empName;
		this.SALARY = salary;
		this.GROSSSALARY = GROSSSALARY;
	}

	public void Display()
	{
		Console.WriteLine("Employee Number:" + EMPNO);
		Console.WriteLine("Employee Name:" + EMPNAME);
		Console.WriteLine("Employee Salary:" + SALARY);
		Console.WriteLine("Gross Salary :" + GROSSSALARY);

	}

}
class Program1
{
	public static void Main(string[] args)
    {
		EmployeeException e = new EmployeeException(1,"Vaish",7000);
		e.Display();
		e.CalculateSalary();

    }
}
