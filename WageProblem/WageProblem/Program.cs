using System;

namespace WageProblem
{
    class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome Employee Wage Computation");
			dailyEmployeeWage();
		}

		public static int dailyEmployeeWage()
		{
			int wagePerHour = 20;
			int dayHour = 8;
			int dailyEmployeeWage = wagePerHour * dayHour;
			Console.WriteLine("Daily Employee Wage is : {0}", dailyEmployeeWage);
			return dailyEmployeeWage;
		}
	}
}
