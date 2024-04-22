using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoStoreManagmentModelLibrary;

namespace VideoStoreManagmentBLLibrary
{
    public class CustomerService : ICustomerService
    {
        private readonly List<Customer> customers;

        public CustomerService(List<Customer> customers)
        {
            // Initialize the customers list
            this.customers = customers ?? new List<Customer>();
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public Customer GetCustomerById(int customerId)
        {
           
            return customers.Find(c => c.CustomerId == customerId);
            IDnotFoundException();


        }

        private void IDnotFoundException()
        {
            throw new NotImplementedException();
        }
    }
    
}
