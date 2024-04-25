namespace ShoppingApp
{
    internal class Program
    {
        public delegate int multiply(int n1, int n2);
        void methodname(multiply mul)
        {
            int n1 = 2, n2 = 9;
            int res=mul(n1, n2);
            Console.WriteLine($"The sum of {n1} and {n2} is {res}");
        }

        public delegate int calcDel(int n1, int n2);//creating a type that refferes to a method
        void Calculate(calcDel cal)
        {
            int n1 = 10, n2 = 20;
            int result = cal(n1, n2);
            Console.WriteLine($"The sum of {n1} and {n2} is {result}");
        }
        public int Add(int num1, int num2)
        {
            return (num1 + num2);
        }
        public int mdd(int num1, int num2)
        {
            return (num1 * num2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program program = new Program();
            calcDel c1 = new calcDel(program.Add);
            multiply m=new multiply(program.mdd);
            program.methodname(m);
            program.Calculate(c1);

        }
    }
}
