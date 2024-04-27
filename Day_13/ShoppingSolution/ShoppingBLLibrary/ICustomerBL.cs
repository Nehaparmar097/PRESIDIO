﻿using ShoppingModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBLLibrary
{
    public interface ICustomerBL
    {
        Customer AddCustomer(Customer customer);
        Customer UpdateCustomer(Customer customer);
        Customer GetCustomerById(int customerId);
        List<Customer> GetAllCustomers();
        bool DeleteCustomer(int customerId);
    }
}
