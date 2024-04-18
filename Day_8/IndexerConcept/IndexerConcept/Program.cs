using System.Xml.Linq;

namespace IndexerConcept
{
    internal class Program
    {
        internal class Student
        {
            public int Id { get; set; }
            string[] skills = new string[5];
            public string Name { get; set; }
            /// <summary>
            /// we use this keyword, we make behave a object as an array
            /// 
            /// </summary>
            /// <param name="index"> index at which we wanna put value</param>
            /// <returns></returns>
            public string this[int index]
            {
                 get { return skills[index]; }
                
                set { skills[index] = value; }
            }
            /// <summary>
            /// if i ant any perticular thing there where i overload this
            /// 
            /// </summary>
            /// <param name="sname"></param>
            /// <returns></returns>
            public int this[string sname]
            {
                get
                {
                    for (int i = 0; i < skills.Length; i++)
                    {
                        if (skills[i] == sname)
                            return i;
                    }
                    return -1;
                }
            }
            public override string ToString()
            {
                string data = Id + " " + Name + " ";
                for (int i = 0; i < skills.Length; i++)
                    data += skills[i] + " ";
                return data;
            }
        }
        static void Main(string[] args)
        {
            /*Student student = new Student() { Name = "Ramu", Id = 101 };
            student[4] = "C";
            student[1] = "Java";
            student[2] = "C#";
            Student student = new Student() { Name = "Ramu", Id = 101 };
            Console.WriteLine(student);*/
           
        }
    }
}
