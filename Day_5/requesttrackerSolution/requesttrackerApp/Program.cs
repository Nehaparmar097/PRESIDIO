using requesttrackeremployee;

namespace RequestTrackerApplication
{
    internal class Program
    {
        Employee[] employees;
        public Program()
        {
            employees = new Employee[3];
        }
        void PrintMenu()
        {
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Print Employees");
            Console.WriteLine("3. Search Employee by ID");
            Console.WriteLine("4. edit Employee name by ID");
            Console.WriteLine("5. for deleting employee by id");
            Console.WriteLine("0. Exit");
        }
        void EmployeeInteraction()
        {
            int choice = 0;
            do
            {
                PrintMenu();
                Console.WriteLine("Please select an option");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Bye.....");
                        break;
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        PrintAllEmployees();
                        break;
                    case 3:
                        SearchAndPrintEmployee();
                        break;
                    case 4:
                        EditEmployeeName();
                        break;
                    case 5:
                        DeletingelementbyID();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again");
                        break;
                }
            } while (choice != 0);
        }
        void AddEmployee()
        {
            if (employees[employees.Length - 1] != null)
            {
                Console.WriteLine("Sorry we have reached the maximum number of employees");
                return;
            }
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] == null)
                {
                    employees[i] = CreateEmployee(i);
                }
            }

        }
        void PrintAllEmployees()
        {
            if (employees[0] == null)
            {
                Console.WriteLine("No Employees available");
                return;
            }
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] != null)
                    PrintEmployee(employees[i]);
            }
        }
        Employee CreateEmployee(int id)
        {
            Employee employee = new Employee();
            employee.Id = 101 + id;
            employee.BuildEmployeeFromConsole();
            return employee;
        }

        void PrintEmployee(Employee employee)
        {
            Console.WriteLine("---------------------------");
            employee.PrintEmployeeDetails();
            Console.WriteLine("---------------------------");
        }
        int GetIdFromConsole()
        {
            int id = 0;
            Console.WriteLine("Please enter the employee Id");
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid entry. Please try again");
            }
            return id;
        }
        /// <summary>
        /// searing for the perticular record
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Employee SearchEmployeeById(int id)
        {
            Employee employee = null;
            for (int i = 0; i < employees.Length; i++)
            {

                if (employees[i] != null && employees[i].Id == id)
                {
                    employee = employees[i];
                    break;
                }
            }
            return employee;
        }
        /// <summary>
        /// printing perticular element by searching by id
        /// </summary>
        void SearchAndPrintEmployee()
        {
            Console.WriteLine("Print One employee");
            int id = GetIdFromConsole();
            Employee employee = SearchEmployeeById(id);
            if (employee == null)
            {
                Console.WriteLine("No such Employee is present");
                return;
            }
            PrintEmployee(employee);
        }
        
        /// <summary>
        /// upadating employee name
        /// </summary>
       void EditEmployeeName()
        {
           // Console.WriteLine("Print One employee");
            int id = GetIdFromConsole();
            Employee employee = SearchEmployeeById(id);
            for (int i=0;i<employees.Length;i++)
            {
                if(id == employees[i].Id)
                {
                    Console.WriteLine($"enter name which you want to replacce {employees[i].Name}");
                    string name=Console.ReadLine();
                    employees[i].Name = name;
                }
            }
            PrintEmployee(employee);
        }
        /// <summary>
        /// creating new array of  1siz eless and putiing all elements to add except that deleted index;
        /// </summary>
        void DeletingelementbyID()
        {
            int id= GetIdFromConsole();
            Employee employee = SearchEmployeeById(id);
            Employee[] newemp=new Employee[employees.Length-1];
            

            
                int j = 0;
                for (int i = 0; i < employees.Length; i++)
                {
                    if (employees.Length ==  0  && id != employees[i].Id)
                    {
                        newemp[j] = employees[i];
                        j++;

                    }
                }
            
            if(employees[0] != null  && newemp.Length == (employees.Length)-1)
            {
                Console.WriteLine("sccuesfully deleted element");
            }
            else { Console.WriteLine("document not found"); }
            employees = newemp;
            PrintAllEmployees();
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.EmployeeInteraction();
        }
    }
}
