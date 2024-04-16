using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GovtRulesLibrary
{
    
        public class CTS : Employee, IGovtRules
        {
            public CTS(int empId, string name, string dept, string desg, double basicSalary)
                : base(empId, name, dept, desg, basicSalary)
            {
            }
        public CTS() { }
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
            salary = Convert.ToDouble(Console.ReadLine());

        }
        // Console.WriteLine("enter number of year of experiance in campany");

        public override void PrintEmployeeDetails()
        {
            Console.WriteLine("cts Employee Id : " + empId);
            Console.WriteLine("cts Employee Name " + Name);
            Console.WriteLine("cts Employee Department : " + Dept);
            Console.WriteLine("cts Employee Designation : " + Desg);
            double ans = EmployeePF(salary);
            Console.WriteLine("cts Employee PF Contribution: " + ans);
            Console.WriteLine("cts Employee Gratuity Amount: " + GratuityAmount(10, salary));
            Console.WriteLine("cts Employee leave deatils are: " + LeaveDetails());// Assuming serviceCompleted is 0 for now
        }

        public double EmployeePF(double basicSalary)
            {
                
                return basicSalary * 0.12;
            }

            public string LeaveDetails()
            {
                return "Leave Details for cts:\n" +
                       "2 days of Casual Leave per month\n" +
                       "5 days of Sick Leave per year\n" +
                       "5 days of Privilege Leave per year";
            }

            // Gratuity not applicable for XYZ
            public double GratuityAmount(float serviceCompleted, double basicSalary)
            {
                return 0; // Not applicable
            }
        }
        /* public int yearOfExperiance { get; set; }

         public CTS(int yearOfExperiance)
         {
             this.yearOfExperiance = yearOfExperiance;
         }
         public override void BuildEmployeeFromConsole()
         {
             Console.WriteLine("enter number of service");
             yearOfExperiance = Convert.ToInt32(Console.ReadLine());
         }*/





    }

