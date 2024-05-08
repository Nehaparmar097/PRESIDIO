using DoctorAppointmentDALLibrary.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointmentDALLibrary
{
    public class DoctorRep : IRepository<int, Doctor>
    {
        readonly Dictionary<int, Doctor> _Doctor;
        public DoctorRep()
        {
            _Doctor = new Dictionary<int, Doctor>();
        }
        int GenerateId()
        {
            if (_Doctor.Count == 0)
                return 1;
            int id = _Doctor.Keys.Max();
            return ++id;
        }
        public Doctor Add(Doctor item)
        {
            if (_Doctor.ContainsValue(item))
            {
                return null;
            }
            _Doctor.Add(GenerateId(), item);
            return item;
        }

        public Doctor Delete(int key)
        {
            if (_Doctor.ContainsKey(key))
            {
                var department = _Doctor[key];
                _Doctor.Remove(key);
                return department;
            }
            return null;
        }

        public Doctor Get(int key)
        {
            return _Doctor.ContainsKey(key) ? _Doctor[key] : null;
        }

        public List<Doctor> GetAll()
        {
            if (_Doctor.Count == 0)
                return null;
            return _Doctor.Values.ToList();
        }

        public Doctor Update(Doctor item)
        {
            if (_Doctor.ContainsKey(item.Id))
            {
                    _Doctor[item.Id] = item;
                    return item;
                }
                return null;
            
        }
    }
}

