using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStoreManagmentModelLibrary
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public Customer(int customerId, string name, int age, string email)
        {
            CustomerId = customerId;
            Name = name;
            Age = age;
            Email = email;
        }
        public virtual void BuildEmployeeFromConsole()
        {
            Console.WriteLine("Please enter the Name");
            Name = Console.ReadLine();
            Console.WriteLine("please enter your age");
            Age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Doctors Speciliztion");
            Email = Console.ReadLine();
           
        }

    }
}
