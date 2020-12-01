using System;

namespace EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            dailyEmployeeWage();
        }
        public static void monthWage()
            {
            int wagePerHour = 20;
            int dayHour = 8;
            int dailyEmployeeWage = wagePerHour * dayHour;
            int workiDayInMonth = 20;
            int monthWage = workiDayInMonth * dailyWage;
                Console.WriteLine(" Employee Wage for Monthis : {0}", monthWage);
            }
        
    }
}
