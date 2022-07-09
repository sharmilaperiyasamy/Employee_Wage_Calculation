using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_wage
{
    internal class Employee_Details
    {
        public string Company;
        public int total_wage, total_Working_hours, total_workingDays, wage_per_hour;
        public Employee_Details(string Company, int total_Working_hours, int total_workingDays, int wage_per_hour)
        {
            this.Company = Company;
            this.total_Working_hours = total_Working_hours;
            this.total_workingDays = total_workingDays;
            this.wage_per_hour = wage_per_hour;
        }

        public void getDetails(int total_wage)
        {
            this.total_wage = total_wage;
        }
        public String showDetails()
        {
            return "Total Monthly Wages of " + Company + " is " + total_wage;
        }
    }
}
