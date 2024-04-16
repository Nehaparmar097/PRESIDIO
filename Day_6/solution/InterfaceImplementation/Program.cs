using GovtRulesLibrary;

namespace InterfaceImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /*  ABC employees =new ABC(1);
            employees.BuildEmployeeFromConsole();
            employees.PrintEmployeeDetails();
            */
          //for class abc
            ABC abcEmployee = new ABC();
            abcEmployee.BuildEmployeeFromConsole();
            Console.WriteLine("\nEmployee Details:");
            abcEmployee.PrintEmployeeDetails();
          //for cts class
            CTS ctsEmployee = new CTS();
            ctsEmployee.BuildEmployeeFromConsole();
            Console.WriteLine("\nEmployee Details:");
            ctsEmployee.PrintEmployeeDetails();


        }
    }
}
