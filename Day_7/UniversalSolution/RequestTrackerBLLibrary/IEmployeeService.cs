using requestTrackerLibrary;
using RequestTrackerDALLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTrackerBLLibrary
{
    public interface IEmployeeService
    {
        int AddEmployee(Employee employee);
        Employee GetEmployeeById(int id);

        Employee GetEmployeeByName(string employeeName);
        Employee UpdateEmployee(Employee employee);
       
      //  List<Employee> GetEmployeesByDepartment(int departmentId);
        void RemoveEmployee(int employeeId);
    }
}
