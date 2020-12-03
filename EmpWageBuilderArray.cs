using System;

public class EmpWageBuilderArray
{
    public const int ispartTime = 1;
    public const int isFullTime = 2;

    private int nuOfCompany = 0;
    private CompanyEmpWage[] companyEmpWageArray;

    public EmpWageBuilderArray()
    { 
        this.companyEmpWageArray = new companyEmpWage[5];
    }

    public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkDays, int maxhourPerMonth) 
    {
        companyEmpWageArray[nuOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkDays, maxhourPerMonth);
        nuOfCompany++;
    }

    public void computeEmpWage() 
    {
        for (int i = 0; i < nuOfCompany; i++)
        {
            companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
            Console.WriteLine(this.companyEmpWageArray[i].ToString);
        }
    }

    public void computeEmpWage(CompanyEmpWage companyEmpWage)
    {
        int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

        while (totalEmpHrs <= companyEmpWage.maxhourPerMonth && totalWorkingDays < companyEmpWage.numOfWorkDays)
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
            Console.WriteLine("Day{0}", totalWorkingDays, "Emp Hours{0}", empHrs);
        }
        return totalEmpHrs * companyEmpWage.empRatePerHour;
    }
}
