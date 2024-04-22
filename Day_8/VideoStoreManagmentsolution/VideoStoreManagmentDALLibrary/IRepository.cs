using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStoreManagmentDALLibrary
{
       /// <summary>
       /// using this interface we are inheriting and implementing in class
       /// </summary>
       /// <typeparam name="K">type of that data</typeparam>
       /// <typeparam name="T">classs</typeparam>
        public interface IRepository<K, T> where T : class
        {

            List<T> GetAll();
            T Get(K key);
            T Add(T item);
            T Update(T item);
            T Delete(K key);
          
          
        }

    }

