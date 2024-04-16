using System.Xml.Linq;

namespace GovtRulesLibrary
{
    
    public class Employee : IGovtRules
    {
        public int empId { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Desg { get; set; }
        public double salary { get; set; }
        public Employee()
        {

        }
        public Employee(int empId, string name, string dept, string desg, double salary)
        {
            empId = empId;
            Name = name;
            Dept = dept;
            Desg = desg;
           salary = salary;
        }
        public Employee(string empId)
        {
        }
      
        public virtual void BuildEmployeeFromConsole()
        {
           /* Console.WriteLine("enter employee id");
            empId=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the Name");
            Name = Console.ReadLine() ?? String.Empty;
            Console.WriteLine("enter your department");
            Dept=Console.ReadLine() ?? String.Empty;
            Console.WriteLine("enter your your designation");
            Desg= Console.ReadLine() ?? String.Empty;
            Console.WriteLine("enter your basic salary");
            salary=Convert.ToDouble(Console.ReadLine());*/
        }

        public virtual void PrintEmployeeDetails()
        {
            //Console.WriteLine("Employee Type : " + Type);
         /*   Console.WriteLine("Employee Id : " + empId);
            Console.WriteLine("Employee Name " + Name);
            Console.WriteLine("Employee department : " + Dept);
            Console.WriteLine("Employee designation : " + Desg);
            Console.WriteLine("Employee pf is:" + EmployeePF(salary));
            Console.WriteLine("Employee graduty  is:" + gratuityAmount(0,salary));*/
        }
        public double EmployeePF(double basicSalary)
        {
            return 0;
        }

        public double gratuityAmount(float serviceCompleted, double salary)
        {
            /* double gratuity = 0.0;

             if (serviceCompleted > 20)
             {
                 gratuity = salary * 3;
             }
             else if (serviceCompleted > 10 && serviceCompleted <= 20)
             {
                 gratuity = salary * 2;
             }
             else if (serviceCompleted > 5 && serviceCompleted <= 10)
             {
                 gratuity = salary;
             }

             return gratuity;*/
            return 0;
        }

        string IGovtRules.LeaVeDetails()
        {
            throw new NotImplementedException();
        }
    }
}
