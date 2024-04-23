using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorsAppontmentModelLibrary
{
    public class Appointments
    {   
        public int Id {  get; set; }
        public DateTime DateTime { get; set; }  
        public string Location { get; set; }

        // Constructor
        
        public Appointments(string location)
        {
            DateTime = DateTime.Now; 
            Location = location;
        }

      
        public override string ToString()
        {
            return $"\n appointment fixed...............................\n Appointment time: {DateTime}, \n Location to visit: {Location}";
        }
    }
}
