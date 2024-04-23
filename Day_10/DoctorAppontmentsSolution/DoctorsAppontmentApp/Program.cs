using DoctorsAppontmentModelLibrary;

namespace DoctorsAppontmentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Doctor doctor = new Doctor();
             doctor.BuildEmployeeFromConsole();*/
            

                        Doctor doctor1 = new Doctor(1, "Neha parmar", "Cardiologist");
            //patient deatil
                        Patient patient1 = new Patient(1, "yukta", "Fever", 100, new Appointments("Chennai"));
                        Patient patient2 = new Patient(2, "laxmi", "Headache", 300, new Appointments(" Chennai egmore"));
                        Patient patient3 = new Patient(3, "shailu", "ache", 30, new Appointments("Central Bus Stand, Chennai"));


            doctor1.Patients.Add(patient1);
                        doctor1.Patients.Add(patient2);


                        Console.WriteLine(doctor1);


                        Console.WriteLine("Patients:");
                        foreach (var patient in doctor1.Patients)
                        {
                            Console.WriteLine(patient);
                            Console.WriteLine("Appointments:");
                            Console.WriteLine(patient.Appointment); // Print the appointment details for each patient
                        }

          /*  PatientRepo patientRepo = new PatientRepo();

           
            Patient newPatient = new Patient
            {
                Id = 1,
                PatientName = "Neha parmar",
                Disease = "Fever",
                Fee = 50,
                Appointment = new Appointments("Chennai")
            };*/
           
        }
    }
}
