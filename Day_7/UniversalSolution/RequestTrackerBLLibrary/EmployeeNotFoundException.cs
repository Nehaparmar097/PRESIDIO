using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RequestTrackerBLLibrary
{
    public class EmployeeNotFoundException : Exception
    {
        public EmployeeNotFoundException()
            : base("Employee not found")
        {
        }

        public EmployeeNotFoundException(string message)
            : base(message)
        {
        }

        public EmployeeNotFoundException(int id)
            : base($"Employee with ID '{id}' not found")
        {
        }
    }
}
