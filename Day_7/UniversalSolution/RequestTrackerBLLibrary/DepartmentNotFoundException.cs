using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace RequestTrackerBLLibrary
{
    public class DepartmentNotFoundException:Exception
    {
        /* string msg;
         public DepartmentNotFoundException()
         {
             msg = "Department not found";
         }
         public override string Message => msg;*/
        public DepartmentNotFoundException()
             : base("Department not found")
        {
        }

        public DepartmentNotFoundException(string message)
            : base(message)
        {
        }

        public DepartmentNotFoundException(int id)
            : base($"Department with ID '{id}' not found")
        {
        }
    }
}
