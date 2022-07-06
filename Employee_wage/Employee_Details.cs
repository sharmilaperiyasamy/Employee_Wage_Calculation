using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_wage
{
    internal class Employee_Details
    {
        public void CheckAttendance()
        {
            int Full_Time = 1;
            Random rand = new Random();
            int Attendance = rand.Next(0,2);
            if (Attendance == Full_Time)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employe is Absent");
            }
        }
    }
}
