using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_wage
{
    internal class Employee_Wage_Builder
    {
        public void getWageData()
        {
            Console.WriteLine("Number of Companies you want to add:");
            int numberOfCompany = Convert.ToInt32(Console.ReadLine());
            while (numberOfCompany > 0)
            {
                Employee_Details emp = new Employee_Details();
                int emp_Check = emp.CheckAttendance();
                Console.WriteLine("Enter the total Working Hours of Company:");
                int total_Working_hours = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter total Working Days of Company:");
                int total_workingDays = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Wages Per Hour of Company:");
                int wage_per_hour = Convert.ToInt32(Console.ReadLine());
                emp.Cal_Wage(emp_Check, total_Working_hours, total_workingDays, wage_per_hour);
                numberOfCompany--;
            }
        }
    }
}
