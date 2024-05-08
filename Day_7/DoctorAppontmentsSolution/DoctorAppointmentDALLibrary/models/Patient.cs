using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointmentDALLibrary.models
{
    public class Patient
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public string Disease { get; set; }
        public int Fee { get; set; }

    }
}
