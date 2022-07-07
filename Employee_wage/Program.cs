Employee_wage.Employee_Details Company_1 = new Employee_wage.Employee_Details();
int emp_Check = Company_1.CheckAttendance();

Console.WriteLine("Company 1 : Employee wage : ");
Company_1.Cal_Wage(emp_Check, 200, 90, 20);

Console.WriteLine("------------------------------------");
Employee_wage.Employee_Details Company_2 = new Employee_wage.Employee_Details();
Console.WriteLine("Company 2 : Employee wage : ");
Company_2.Cal_Wage(emp_Check, 500, 100, 25);
