using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doctorsapp_task.modul
{
    internal class Doctor
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public int Age { get; set; }
        

        public int Exp { get; set; }
        public string Qualifications { get; set; }
        public string Speciality { get; set; }
        public Doctor(int id)
        { 
            Id = id;
        }    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">string type</param>
        /// <param name="age">integer age of doctor</param>
       
        /// <param name="exp">year of experiance in int</param>
        /// <param name="qualifications"></param>
        /// <param name="speciality">their speciality</param>
        public Doctor(string name, int age, int exp, string qualifications, string speciality)
        {
            Name = name;
            Age = age;
            
            Exp = exp;
            Qualifications = qualifications;
            Speciality = speciality;
        }
        public void PrintDoctorsDetails()
        {
            Console.WriteLine($"doctors Id\t:\t{Id}");
            Console.WriteLine($"doctors name\t:\t{Name}");
            Console.WriteLine($"age of doctors \t: \t{Age}");
            Console.WriteLine($"year of experiance\t:\t{Qualifications}");
            Console.WriteLine($"Employee Salary\t:\tRs.{Speciality}");
            
        }
        public void greetmessage()
        {
            Console.WriteLine("get well soon !!!!!!");
        }
    }
}
