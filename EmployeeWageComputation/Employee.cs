using System;

namespace EmployeeWageComputation
{
    class Employee
    {

        public const int ispartTime = 1;
        public const int isFullTime = 2;
        public static int computeEmpWage(string company, int empRatePerHour, int numOfWorkDays, int maxhourPerMonth)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= maxhourPerMonth && totalWorkingDays < numOfWorkDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
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
                Console.WriteLine("Day{0}", totalWorkingDays, "Emp Hours{1}",empHrs);
            }
            int totalEmpWage;
            totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for company{0}{1}  ", company, totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            computeEmpWage("DMart", 20, 2, 10);
            computeEmpWage("Reliance", 10, 4, 40);
        }
    }
}
