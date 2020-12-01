using System;

namespace WageProblem
{
    class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome Employee Wage Computation");
			checkEmployeeAttendence();
		}

		public static void checkEmployeeAttendence()
		{
			Random rd = new Random();
			int rand_num = rd.Next(0, 1);
			if (rand_num == 1)
				Console.WriteLine("Employee is Present");
			else
				Console.WriteLine("Employee is Not Present");
		}
	}
}
