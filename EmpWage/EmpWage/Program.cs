using System;

namespace EmpWage
{
    class Program
    {
        static void Main(string[] args)
		{
			Console.WriteLine("Welcome Employee Wage Computation");
			while (true)
			{
				Console.WriteLine("1.Check Employee Attendence\t 2.Daily Employee Wage\t 3.Part Time Wage\t 4.Empoyee Month Wage\t 5.Daily To Daily Employee Wage");
				int choice = Convert.ToInt32(Console.ReadLine());
				switch (choice)
				{
					case 1:
						Random rd = new Random();
						int rand_num = rd.Next(0, 1);
						checkEmployeeAttendence(rand_num);
						break;
					case 2:
						dailyEmployeeWage();
						break;
					case 3:
						partTimeWage();
						break;
					case 4:
						monthWage();
						break;
				}
			}
		}

		public static void checkEmployeeAttendence(int num)
		{
			if (num == 1)
				Console.WriteLine("Employee is Present");
			else
				Console.WriteLine("Employee is Not Present");
		}
		public static int dailyEmployeeWage()
		{
			int wagePerHour = 20;
			int dayHour = 8;
			int dailyEmployeeWage = wagePerHour * dayHour;
			Console.WriteLine("Daily Employee Wage is : {0}", dailyEmployeeWage);
			return dailyEmployeeWage;
		}
		public static void partTimeWage()
		{
			int wagePerHour = 20;
			int partTimeHour = 8;
			int partTimeWage = wagePerHour * partTimeHour;
			Console.WriteLine("Part Time Employee Wage is : {0}", partTimeWage);
		}
		public static void monthWage()
		{
			int workiDayInMonth = 20;
			int dailyWage = dailyEmployeeWage();
			int monthWage = workiDayInMonth * dailyWage;
			Console.WriteLine(" Employee Wage for Monthis : {0}", monthWage);
		}
		
	
    }
}
