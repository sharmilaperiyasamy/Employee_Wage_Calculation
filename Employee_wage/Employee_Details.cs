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
        int emp_hour, wage;
        public int CheckAttendance()
        {
            Random rand = new Random();
            int Attendance = rand.Next(0, 3);
            if (Attendance == Full_Time)
            {
                Console.WriteLine("Employee is Present");
            }
            else if (Attendance == Part_Time)
            {
                Console.WriteLine("Employee is Present for part time");
            }
            else
            {
                Console.WriteLine("Employe is Absent");
            }
            return Attendance;
        }

            public void Cal_Wage(int emp_Check)
            {
                switch(emp_Check)
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
            wage = emp_hour * wage_per_hour;
            Console.WriteLine("Employee's Daily wage : " + wage);
            }
    }
}
