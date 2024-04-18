using RequestTrackerDALLibrary;
using requestTrackerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTrackerBLLibrary
{
    public class EmployeeBL : IEmployeeService
    {
        readonly IRepository<int, Employee> _employeeRepository;
        public EmployeeBL()
        {
            _employeeRepository = new EmployeeRepository();
        }
        public EmployeeBL(IRepository<int, Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public int AddEmployee(Employee employee)
        {
            var result = _employeeRepository.Add(employee);

            if (result != null)
            {
                return result.Id;
            }
            throw new DuplicateEmployeeNameException();
        }

        public Employee GetEmployeeById(int id)
        {
            Employee employee = _employeeRepository.Get(key: id);

            // Check if Employeess is found
            if (employee != null)
            {
                return employee;
            }
            else
            {
                throw new EmployeeNotFoundException();
            }
        }


        public Employee GetEmployeeByName(string employeeName)
        {
            Employee employee = _employeeRepository.Find(e => e.Name == employeeName);

            // Check if employee is found
            if (employee != null)
            {
                return employee;
            }
            else
            {
                throw new EmployeeNotFoundException($"Employee with name '{employeeName}' not found");
            }
        }

        //this part throwing error
        /*  public List<Employee> GetEmployeesByDepartment(int employeeId)
          {
              List<Employee> employee = _employeeRepository.Find(e => e.Id == employeeId).ToList();

              // Check if employees are found
              if (employee.Count > 0)
              {
                  return employee;
              }
              else
              {
                  throw new EmployeeNotFoundException();
              }
          }*/

        public void RemoveEmployee(int employeeId)
        {
            Employee removedEmployee = _employeeRepository.Delete(employeeId);

            // Check if the employee is successfully removed
            if (removedEmployee == null)
            {
                // If employee is not found, throw an exception
                throw new EmployeeNotFoundException($"Employee with ID '{employeeId}' not found");
            }
        }
        public Employee UpdateEmployee(Employee employee)
        {
            Employee updatedEmployee = _employeeRepository.Update(employee);

            if (updatedEmployee == null)
            {
                throw new EmployeeNotFoundException($"Employee with ID '{employee.Id}' not found");
            }
            else
            {
                return updatedEmployee;
            }

        }

       
       
    }
}
