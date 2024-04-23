using DoctorsAppontmentModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointmentDALLibrary
{
    public class AppointmentRepo : IRepository<int, Appointments>
    {
        readonly Dictionary<int, Appointments> Appointments;
        public AppointmentRepo()
        {
            Appointments = new Dictionary<int, Appointments>();
        }
        int GenerateId()
        {
            if (Appointments.Count == 0)
                return 1;
            int id = Appointments.Keys.Max();
            return ++id;
        }
        public Appointments Add(Appointments item)
        {
            if (Appointments.ContainsValue(item))
            {
                return null;
            }
            Appointments.Add(GenerateId(), item);
            return item;
        }

        public Appointments Delete(int key)
        {
            if (Appointments.ContainsKey(key))
            {
                var department = Appointments[key];
                Appointments.Remove(key);
                return department;
            }
            return null;
        }

        public Appointments Get(int key)
        {
            return Appointments.ContainsKey(key) ? Appointments[key] : null;
        }

        public List<Appointments> GetAll()
        {
            if (Appointments.Count == 0)
                return null;
            return Appointments.Values.ToList();
        }

        public Appointments Update(Appointments item)
        {
            if (Appointments.ContainsKey(item.Id))
            {
                Appointments[item.Id] = item;
                return item;
            }
            return null;
        }
    }
}
