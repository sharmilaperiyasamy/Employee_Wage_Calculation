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
        int Part_Time = 2;
        int wage_per_hour = 20;
        public void CheckAttendance()
        {
            Random rand = new Random();
            int Attendance = rand.Next(0,3);
            if (Attendance == Full_Time)
            {
                Console.WriteLine("Employee is Present");
                int emp_hour = 8;
                double wage = emp_hour * wage_per_hour;
                Console.WriteLine("Daily wage of the Employee : " + wage);
            }
            else if(Attendance == Part_Time)
                {
                Console.WriteLine("Employee is Present for part time");
                int emp_hour = 4;
                double wage = emp_hour * wage_per_hour;
                Console.WriteLine("Daily wage of the Part Time Employee :" + wage);
            }
            else
            {
                Console.WriteLine("Employe is Absent");
            }
        }
    }
}
