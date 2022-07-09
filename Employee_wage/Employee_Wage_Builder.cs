using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_wage
{
    internal class Employee_Wage_Builder
    {
        int numberOfCompany = 0;
        Employee_Details[] emp = new Employee_Details[5];

        public void addCompanyDetails(string Company, int total_Working_hours, int total_workingDays, int wage_per_hour)
        {
            emp[this.numberOfCompany] = new Employee_Details(Company, total_Working_hours, total_workingDays, wage_per_hour);
            numberOfCompany++;
        }
        public void getWageData()
        {
            for (int i = 0; i < numberOfCompany; i++)
            {
                emp[i].getDetails(this.Cal_Wage(this.emp[i]));
                Console.WriteLine(emp[i].showDetails());
            }

        }

        private int Cal_Wage(Employee_Details emp)
        {
            int working_hrs = 0, working_days = 0, emp_hour = 0, total_wage;
            while (working_hrs <= emp.total_Working_hours && working_days <= emp.total_workingDays)
            {
                working_days++;
                Random random = new Random();
                int emp_Check = random.Next(0, 3);
                switch (emp_Check)
                {
                    case 1:
                        emp_hour = 8;
                        break;
                    case 2:
                        emp_hour = 4;
                        break;
                    default:
                        emp_hour = 0;
                        break;
                }
                working_hrs = working_hrs + emp_hour;
            }
            total_wage = working_hrs * emp.wage_per_hour;
            return total_wage;
        }
    }
}
