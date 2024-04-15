using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace cownadbullgameApp
{
    internal class Program
      {

        void PrintMenu()
        {
            Console.WriteLine("1. Play Game");
            Console.WriteLine("0. Exit");
        }
        /// <summary>
        /// swich case for play its 1 or exit its 0
        /// </summary>
        void SwichchoceMenu()
        {
            Console.WriteLine("enter your main game");
            string gamestaing = Console.ReadLine();
            int choice = 0;
            do
            {
                PrintMenu();
                Console.WriteLine("Please select an option");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Bye.....");
                        break;
                    case 1:
                        TakeingUserInput(gamestaing);
                        break;
                    default:
                        Console.WriteLine("invallid emtry");
                        break;



                }
            } while (choice!=0);
        }
        void printresult(int cow,int bull)
        {
            Console.WriteLine($"cow : {cow} ,Bull : {bull}");
        }
        /// <summary>
        /// game logic
        /// </summary>
        /// <param name="input">give one base string  </param>
        /// <param name="GameString">every time give new string to do camparizon</param>
        void gamepoints(string input,string GameString)
        {
            int cow = 0, bull = 0;

            string copy = GameString;
            for (int i=0;i<4;i++)
            {
                if (input[i]== GameString[i])
                {
                    cow++;
                    input = input.Remove(i, 1).Insert(i, "#");
                    copy = copy.Remove(i, 1).Insert(i, "@");

                }
            }
            for(int i=0;i<4;i++)
            {
                for(int j=0;j<4;j++)
                {
                    if (Char.ToUpper(input[i]) == Char.ToUpper(copy[j]))
                    {
                        bull++;
                        break;
                    }
                }
            }
            printresult(cow,bull);
        }
        void TakeingUserInput(string s)
        {
            Console.WriteLine("enter one more string");
            string input=Console.ReadLine();
            if(input.Length!=4) Console.WriteLine("wrong input");
            else gamepoints(input, s);
        }
     
        static void Main(string[] args)
        {
            Program program = new Program();
           
            program.SwichchoceMenu();

        }

    
}
}
