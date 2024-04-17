
using DoctorsAppontmentModelLibrary;
namespace DoctorAppointmentDALLibrary
{
    public class PatientRepo: IRepository<int, Patient>
    {
        readonly Dictionary<int, Patient> Patient;
        public PatientRepo()
        {
            Patient = new Dictionary<int, Patient>();
        }
        int GenerateId()
        {
            if (Patient.Count == 0)
                return 1;
            int id = Patient.Keys.Max();
            return ++id;
        }
        public Patient Add(Patient item)
        {
            if (Patient.ContainsValue(item))
            {
                return null;
            }
            Patient.Add(GenerateId(), item);
            return item;
        }

        public Patient Delete(int key)
        {
            if (Patient.ContainsKey(key))
            {
                var department = Patient[key];
                Patient.Remove(key);
                return department;
            }
            return null;
        }

        public Patient Get(int key)
        {
            return Patient.ContainsKey(key) ? Patient[key] : null;
        }

        public List<Patient> GetAll()
        {
            if (Patient.Count == 0)
                return null;
            return Patient.Values.ToList();
        }

        public Patient Update(Patient item)
        {
            if (Patient.ContainsKey(item.Id))
            {
                Patient[item.Id] = item;
                return item;
            }
            return null;
        }
    }

}

