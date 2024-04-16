using Microsoft.VisualBasic;
using System;
using System.Threading.Channels;

namespace GovtRulesLibrary
{
    public class ABC : Employee, IGovtRules
    {
       
        public ABC(int empId, string name, string dept, string desg, double salary)
            : base(empId, name, dept, desg, salary)
        {
        }
        
        public ABC()
        {
        }

        public override void BuildEmployeeFromConsole()
        {
            Console.WriteLine("Enter employee id");
            

            empId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the Name");
            Name = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Enter your department");
            Dept = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Enter your designation");
            Desg = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Enter your basic salary");
            salary =Convert.ToDouble(Console.ReadLine());
       
        }
       // Console.WriteLine("enter number of year of experiance in campany");
        
        public override void PrintEmployeeDetails()
        {
            Console.WriteLine("Employee Id : " + empId);
            Console.WriteLine("Employee Name " + Name);
            Console.WriteLine("Employee Department : " + Dept);
            Console.WriteLine("Employee Designation : " + Desg);
            double ans = EmployeePF(salary);
            double pf = (salary * 3.67) / 100;
            salary = salary - pf;
            Console.WriteLine("Employee PF Contribution: " + ans);
            Console.WriteLine("employee currunt salary:"+ salary);
            double gamount = GratuityAmount(10, salary);
            Console.WriteLine("Employee Gratuity Amount: " + gamount);
            Console.WriteLine("Employee leave deatils are: "+ LeaveDetails());// Assuming serviceCompleted is 0 for now
        }

        public double EmployeePF(double salary)
        {
            double pf = (salary *12)/100;
            return pf;
        }

        public string LeaveDetails()
        {
            return "Leave Details for ABC:\n" +
                   "1 day of Casual Leave per month\n" +
                   "12 days of Sick Leave per year\n" +
                   "10 days of Privilege Leave per year";
        }

        public double GratuityAmount(float serviceCompleted, double salary)
        {
            if (serviceCompleted > 5)
            {
                return salary;
            }
            else if (serviceCompleted > 10)
            {
                return salary * 2;
            }
            else if (serviceCompleted > 20)
            {
                return salary * 3;
            }
            else
            {
                return 0;
            }
        }
    }
}
