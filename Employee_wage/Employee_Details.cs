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
        int emp_hour, total_wage;
        public int CheckAttendance()
        {
            Random rand = new Random();
            int Attendance = rand.Next(0, 3);
            if (Attendance == Full_Time)
            {
                Console.WriteLine("Employee is Present for full time");
            }
            else if (Attendance == Part_Time)
            {
                Console.WriteLine("Employee is Present for part time");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            return Attendance;
        }

            public void Cal_Wage(int emp_Check, int total_Working_hours, int total_workingDays, int wage_per_hour)
            {
            int working_hrs = 0, working_days = 0;
            while (working_hrs <= total_Working_hours && working_days <= total_workingDays)
            {
                working_days++;

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
            total_wage = working_hrs * wage_per_hour;
            Console.WriteLine("Employee's total working hours : " + working_hrs);
            Console.WriteLine("Employee's total working days : " + working_days);
            Console.WriteLine("Employee's total wage for month : " + total_wage);
            Console.WriteLine("---------------------------------------------------");
            }
    }
}
