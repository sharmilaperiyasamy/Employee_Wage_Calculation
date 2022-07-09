using Employee_wage;
namespace Employee_wage
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            var log = NLog.LogManager.GetCurrentClassLogger();
            log.Info("Employee Wage calculator has started.\n");
            Console.WriteLine("Number of Companies you want to add:");
            int numberOfCompany = Convert.ToInt32(Console.ReadLine());
            Employee_Wage_Builder empWageBuilder = new Employee_Wage_Builder();

            while (numberOfCompany > 0)
            {
                Console.WriteLine("Enter the Company : ");
                string Company = Console.ReadLine();
                Console.WriteLine("Enter the total Working Hours of Company :");
                int total_Working_hours = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the total Working Days of Company :");
                int total_workingDays = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Wages Per Hour of Company:");
                int wage_per_hour = Convert.ToInt32(Console.ReadLine());
                empWageBuilder.addCompanyDetails(Company, total_Working_hours, total_workingDays, wage_per_hour);
                numberOfCompany--;
            }
            empWageBuilder.getWageData();
        }
    }
}