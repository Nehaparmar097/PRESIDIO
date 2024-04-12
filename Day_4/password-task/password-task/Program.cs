namespace password_task
{
    internal class Program
    {
        static int Calculate(int [] store)
        {
            int result = 0;
            for(int i = 0; i < 16; i++)
            {
                result += store[i];
            }
            return result;
        }
        static void LogicofMultiplyingalternateBy2(int [] store)
        {
            for (int i = 0; i < 16; i++)
            {
                if (i % 2 != 0)
                {
                    int a = store[i] * 2;

                    if (a > 9)
                    {
                        int b = 0;
                        b += a % 10;
                        a = a / 10;
                        b += a;
                        store[i] = b;
                    }
                    else
                    {
                        store[i] *= 2;
                    }

                }
            }
        
        }
        static void printcode(int n)
        {
            Console.WriteLine($"yourcode number is {n} ");
        }
        static void ConvertingStringToNumarray(string s,int[] store)
        {
            long number = Convert.ToInt64(s);
            // TryParse to handle long int  errors
            if (long.TryParse(s, out number)) 
            {
                int i = 0; 
                while (number > 0 && i < store.Length)
                {
                    long num = number % 10;
                    store[i] = Convert.ToInt32(num);
                    number = number / 10;
                    i++;
                }
    
            }
            else
            {
                Console.WriteLine("Invalid input string.");
            }
            store.Reverse();
        }
        static void check(int Code)
        {
            if (Code % 10 == 0)
            {
                Console.WriteLine("hurrreyy you have logdin");
            }
            else
            {
                Console.WriteLine("you are not a valid user");
            }
        }
        static string firstinputstring()
        {
            Console.WriteLine("enter your 16 digit password");
            string s = Console.ReadLine();
            return s;
        }
        static void passwordvalidation()
        {
            string s = firstinputstring();
            if (s.Length == 16)
            {
                int[] store = new int[16];
                ConvertingStringToNumarray(s, store);
                LogicofMultiplyingalternateBy2(store);
                check(Calculate(store));
            }
            else
            {
                Console.WriteLine("please dail valid password");
            }

        }
        static void Main(string[] args)
        {
            passwordvalidation();
        }
    }
}
