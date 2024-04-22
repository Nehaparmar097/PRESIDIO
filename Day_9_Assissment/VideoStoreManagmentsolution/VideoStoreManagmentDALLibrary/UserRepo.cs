using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoStoreManagmentModelLibrary;

namespace CustomerStoreManagmentDALLibrary
{  /// <summary>
/// performing crud operation user
/// </summary>
    public class UserRepo
    {
        readonly Dictionary<int, Customer> _customer;
        public UserRepo()
        {
            _customer = new Dictionary<int, Customer>();
        }
        int GenerateId()
        {
            if (_customer.Count == 0)
                return 1;
            int id = _customer.Keys.Max();
            return ++id;
        }
        public Customer Add(Customer item)
        {
            if (_customer.ContainsValue(item))
            {
                return null;
            }
            _customer.Add(GenerateId(), item);
            return item;
        }

        public Customer Delete(int key)
        {
            if (_customer.ContainsKey(key))
            {
                var department = _customer[key];
                _customer.Remove(key);
                return department;
            }
            return null;
        }

        public Customer Get(int key)
        {
            return _customer.ContainsKey(key) ? _customer[key] : null;
        }

        public List<Customer> GetAll()
        {
            if (_customer.Count == 0)
                return null;
            return _customer.Values.ToList();
        }

        public Customer Update(Customer item)
        {
            if (_customer.ContainsKey(item.CustomerId))
            {
                _customer[item.CustomerId] = item;
                return item;
            }
            return null;
        }
    }
}
