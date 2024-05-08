using System.Data;
using System.Xml.Linq;

namespace DoctorsAppontmentModelLibrary
{
    public class Doctor
    {
        public int Id { get; set; }
        public string DoctorName { get; set; }
        public string Specialization { get; set; }
        //one doctor can have many patients 1Doctor=>Many Patient
        public List<Patient> Patients { get; set; } 

        public Doctor()
        {
            Patients = new List<Patient>();
        }

        public Doctor(int id, string doctorName, string specialization)
        {
            Id = id;
            DoctorName = doctorName;
            Specialization = specialization;
            Patients = new List<Patient>(); 
        }

        public virtual void BuildEmployeeFromConsole()
        {
            Console.WriteLine("Please enter the Name");
            DoctorName = Console.ReadLine() ;
            Console.WriteLine("Please enter Doctors Speciliztion");
            Specialization = Console.ReadLine() ;
            //  Role = "Employee";
        }


        public override string ToString()
        {
            return "\nDoctors Id : " + Id
                + "\nDoctors Name " + DoctorName
                
                + "\nDoctors specialization " + Specialization;
        }
    }
}
