using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_wage
{
    internal class Employee_Details
    {
        int Full_Time = 1;
        int wage_per_hour = 20;
        public void CheckAttendance()
        {
            Random rand = new Random();
            int Attendance = rand.Next(0,2);
            if (Attendance == Full_Time)
            {
                Console.WriteLine("Employee is Present");
                int emp_hour = 8;
                double wage = emp_hour * wage_per_hour;
                Console.WriteLine("Daily wage of the Employee : " + wage);
            }
            else
            {
                Console.WriteLine("Employe is Absent");
            }
        }
    }
}
