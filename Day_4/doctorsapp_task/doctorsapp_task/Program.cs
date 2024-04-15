using doctorsapp_task.modul;
using System.Threading.Channels;
using System.Transactions;

namespace doctorsapp_task
{
    internal class Program
    {  /// <summary>
    /// this fucntion is take user and put and construct a doctor record.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
       public Doctor CreatinAllDetailOfDoctos(int id)
        {
            Doctor doctor = new Doctor(id);
            Console.WriteLine("Please enter the doctor's name");
            doctor.Name = Console.ReadLine();

            Console.WriteLine("Please enter the  age");
            doctor.Age=Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Please enter number of expreriance doctor have ");
            doctor.Exp=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the doctor's qualifications");
            doctor.Qualifications = Console.ReadLine();
            Console.WriteLine("Please enter the doctor's specialization");
            doctor.Speciality = Console.ReadLine();

            return doctor;


        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("enter how many doctors record you want to record");
            int n = Convert.ToInt32(Console.ReadLine());
            Doctor[] doctor=new Doctor[n];
            for(int i = 0; i < n; i++)
            {

                doctor[i] = program.CreatinAllDetailOfDoctos(101+i);
            }
            for (int i = 0; i < n; i++)
            {
                doctor[i].PrintDoctorsDetails();
            }
            //fuction to et listof any specific speciality doctor
            Console.WriteLine("enter any specializations");
            string s=Console.ReadLine();
            for(int i = 0; i < n;i++)
            {
                if (doctor[i].Speciality==s)
                {
                    doctor[i].PrintDoctorsDetails();
                }
            }
            Doctor one = new Doctor(1);
            one.greetmessage();
        }
    }
}
