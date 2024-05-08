using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointmentDALLibrary.models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string DoctorName { get; set; }
        public string Specialization { get; set; }
        //one doctor can have many patients 1Doctor=>Many Patient
        public List<Patient> Patients { get; set; }
    }
}
