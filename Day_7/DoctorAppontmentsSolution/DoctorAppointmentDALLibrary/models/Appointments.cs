using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointmentDALLibrary.models
{
    public class Appointments
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Location { get; set; }

    }
}
