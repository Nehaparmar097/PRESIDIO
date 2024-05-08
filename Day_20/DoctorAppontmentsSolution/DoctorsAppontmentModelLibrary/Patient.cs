using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DoctorsAppontmentModelLibrary
{
    
        public class Patient :Doctor
        {
            public int Id { get; set; }
            public string PatientName { get; set; }
            public string Disease { get; set; }
            public int Fee { get; set; }
            
        public Appointments Appointment { get; set; } 

            public Patient()
            {
                
                Appointment = null;
            }

            public Patient(int id, string patientName, string disease, int fee, Appointments appointment)
            {
                Id = id;
                PatientName = patientName;
                Disease = disease;
                Fee = fee;
                Appointment = appointment;
            }

            public override string ToString()
            {
                return $"\nPatient id:{Id}\nPatient Name:{PatientName}\n Patient Problem:{Disease}\n Doctors Fee:{Fee}";
            }
        }
    }


