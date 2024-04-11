using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

/*namespace Assignments
{
    internal class program
    {  static int add(int a,int b)
        {
            int sum;
            sum = a + b;
            return sum;
        }
        static int subtract(int a, int b)
        {
            int n;
            n= a - b;
            return n;
        }
        static int multiply(int a, int b)
        {
            int n;
            n = a * b;
            return n;
        }
        static int divide(int a, int b)
        {
            int n;
            if (b == 0) return -1;
            n = a /b;
            return n;
        }
        static int TakeNumber()
        {
            int num1;
            Console.WriteLine("Please enter the the number");
            num1 = Convert.ToInt32(Console.ReadLine());
            return num1;
        }
        static void userinput()
        {
            int a = TakeNumber();
            int b = TakeNumber();
        }
        
        static void printresult(int ans)
        {
            Console.WriteLine($"answer of the above calculation is { ans}");
        }
        static void Calculate()
        {
            int num1, num2;
            num1 = TakeNumber();
            num2 = TakeNumber();
            int a, b, c, d;
            a= add(num1, num2);
            b = subtract(num2, num1);
            c = multiply(num1, num2);
            d = divide(num1, num2);
            printresult(a);
            printresult(b);
            printresult(c);
            printresult(d);
        }
        static void Main(string[] args)
        {
            Calculate();
        }
    }
}*/

//2)  create an application that will find the greatest of the given numbers.
//Take input until the user enters a negative number


/*namespace Assignments
{
    internal class program
    {
        static int addtillzero()
        {
            int a = takeinput();
            int ans = 0;
            while (a >= 0)
            {
                ans = ans + a;
                a = takeinput();

            }
           

            return ans;
        }
        static int takeinput()
        {
            Console.WriteLine("enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
        static void printresult()
        {
            int ans = addtillzero();
            Console.WriteLine($"reult of the givin chain is {ans}");
        }
        static void Main(string[] args)
        {
            printresult();
        }
    }
}*/


//3) Find the avearage of all the numbers that are divisible by 7.
//Take input until the user enters a negative number

/*namespace Assignments
{
    internal class program
    {
        static int addtillzero()
        {
            int a = takeinput();
            int ans = 0,cnt=0;
            
                while (a >= 0)
                {
                if (a % 7 == 0)
                {
                    ans = ans + a;
                    cnt++;
                }
                    a = takeinput();

                }
            int val = 0;

            if (cnt == 0) return 0;
            else val=ans/cnt;


            return val;
        }
       
        static int takeinput()
        {
            Console.WriteLine("enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
        static void printresult()
        {
            int ans = addtillzero();
            Console.WriteLine($"reult of the givin chain is {ans}");
        }
        static void Main(string[] args)
        {
            printresult();
        }
    }
}
*/

//4) Find the length of the given user's name

/*namespace Assignment
{
    internal class program
    {
        static int Countingchar()
        {
            string inputname = Takeinput();
            return inputname.Length;


        }
        static string Takeinput()
        {
            Console.WriteLine("enter your name pleas!!!!");
            string name=Console.ReadLine();
            return name;

        }
        static void Printingresult()
        {
            int len = Countingchar();
            Console.WriteLine($"total number int your name is {len}");
        }
        static void Main() {
            Printingresult();
        } 
    }
}*/

//5) Create a application that will take username and password from user. check if username is "ABC" and passwod is "123". 
//Print error message if username or password is wrong
//Allow user 3 attemts.
//After 3rd attempt if user enters invalid credentials then print msg to intimate user taht he/she has exceeded the number of attempts and stop

/*
namespace Assignments
{
    internal class program
    {    
        static void errormsg()
        {
            Console.WriteLine("you have entered wrong pass word");
        }
        static bool checkingpass()
        {
            string right = "123";
            string pass = TakeUserpass();
            int a = 3;
            while(a>1)
            {
                if(pass==right)
                {
                    return true;
                }
                errormsg();
                a--;
                pass =TakeUserpass();


            }
            return false;

        }
        static void checkinguser()
        {
            string name = TakeUsername();
            if(name == "ABC") {
                Console.WriteLine("hello ABC greetingss!! /n may i know your password");
                if (checkingpass()){
                    Console.WriteLine("hurreyy you are loged in ABC");
                };
                

            }
        }
        static string TakeUsername()
        {
            Console.WriteLine("hello userr greetingss!! /n may i know your name");
            string name=Console.ReadLine();
            return name;

        }
        static string TakeUserpass()
        {   
           
            string pass = Console.ReadLine();
            return pass;

        }

        static void Main(string[] args)
        {
            checkinguser();
        }
    }
}*/


//7) Take a string from user the words seperated by comma(",").
//Seperate the words and find the words with the least number of repeating vowels.
//print the count and the word. If there is a tie then print all the words that tie for the least

/*namespace assignmnets
{
    internal class program
    {
        static int countingone(string s)
        {
            int cnt = 0;
            List<int> v = new List<int>();
            int a = 0, b = 0, c = 0, d = 0, e = 0;
            for (int i=0;i<s.Length; i++) {
              
                if (s[i] == 'a' || s[i] == 'A')
                {
                    a++;
                }
                if (s[i] == 'e' || s[i] == 'E')
                {
                    b++;
                }
                if (s[i] == 'i' || s[i] == 'I')
                {
                    c++;
                }
                if (s[i] == 'o' || s[i] == 'O')
                {
                    d++;
                }
                if (s[i] == 'u' || s[i] == 'U')
                {
                    e++;
                }

            }
            v.Add(a);
            v.Add(b);
            v.Add(c);
            v.Add(d);
            v.Add(e);
            for(int  i=0;i<v.Count;i++)
            {
                if (v[i]>=2)
                {
                    cnt++;
                }
            }
            return cnt;
        }
        static void cfoundingleastone()
        {
            string s = maintring();
            string d = "";
            for(int i=0;i<s.Length;i++)
            {
                if (s[i] == "," )
                {

                }

                }
            }

        }
        static string maintring()
        {
            string s=Console.ReadLine();
            return s;
        }
        static void Main(string[] args)
        {

        }
    }
}
*/
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string with words separated by commas: ");
        string input = Console.ReadLine();

        string[] w = input.Split(',');

        int m = FindMinVowelCount(w);
        var l = FindWordsWithMinVowels(w, m);

        PrintResult(m, l);
    }

    static int C(string w)
    {
        return w.ToLower().Count(c => "aeiou".Contains(c));
    }

    static int FindMinVowelCount(string[] w)
    {
        int m = int.MaxValue;

        foreach (string x in w)
        {
            int c = C(x);
            m = Math.Min(m, c);
        }

        return m;
    }

    static string[] FindWordsWithMinVowels(string[] w, int m)
    {
        return w.Where(x => C(x) == m).ToArray();
    }

    static void PrintResult(int m, string[] l)
    {
        Console.WriteLine($"The word(s) with the least number of repeating vowels ({m}) is/are:");

        foreach (var x in l)
        {
            Console.WriteLine(x.Trim());
        }
    }
}
