using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStoreManagmentBLLibrary
{
    public class IDnotFoundException:Exception
    {
        string msg;
        public IDnotFoundException()
        {
            msg = "ID Not Found";
        }
        public override string Message => msg;
    }
}
