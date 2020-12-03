using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Employee Wage Calculation Project !");
            EmpBuilderArray empWageBuilder = new EmpBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Relience", 10, 4, 20);
            empWageBuilder.addCompanyEmpWage("Real", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Rootstock", 10, 4, 20);
            empWageBuilder.computeEmpWage();
        }


    }
}
