using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoStoreManagmentModelLibrary;


namespace VideoStoreManagmentBLLibrary
{  //interface for public
    public interface ICustomerService
    {
        void AddCustomer(Customer customer);
        Customer GetCustomerById(int customerId);
    }
}
