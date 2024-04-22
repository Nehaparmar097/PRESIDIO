using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoStoreManagmentModelLibrary;

namespace VideoStoreManagmentBLLibrary
{
    public interface ICustomerService
    {
        void AddCustomer(Customer customer);
        Customer GetCustomerById(int customerId);
    }
}
