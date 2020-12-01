using System;

namespace EmpWage
{
    class Program
    {
		public const int ispartTime = 1;
		public const int isFullTime = 2;
		public const int empRatePerHour = 20;
		public const int noOfWorkingDays = 2;
		public const int maxHoursInMonth = 10;

        static void Main(string[] args)
		{
			int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

			while(totalEmpHrs <= maxHoursInMonth && totalWorkingDays < noOfWorkingDays)
			{
				totalWorkingDays++;
				Random random = new Random();
				int empCheck = random.Next(0,3);
				switch(empCheck)
				{
					case ispartTime:
						empHrs = 4;
						break;
					case isFullTime:
						empHrs = 8;
						break;
					default:
						empHrs = 0;
						break;
				}
				totalEmpHrs += empHrs;
				Console.WriteLine("Day{0}", totalWorkingDays,"Emp Hours{0}",empHrs);
			}
			int totalEmpWage = totalEmpHrs * empRatePerHour;
			Console.WriteLine("Total Emp Wage{0}",totalEmpWage);
		}
		
	
    }
}
