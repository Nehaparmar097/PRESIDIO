namespace ExcelLeetCodeQuestion
{
    internal class Program
    {

       
            public string ConvertToTitle(int columnNumber)
            {
                string ans = "";
                Dictionary<int, char> myDict = new Dictionary<int, char>();

                for (int i = 1; i <= 26; i++)
                {
                    char letter = (char)('A' + i - 1);
                    myDict.Add(i, letter);
                }

                while (columnNumber > 0)
                {
                    int remainder = (columnNumber - 1) % 26;
                    ans = myDict[remainder + 1] + ans;
                    columnNumber = (columnNumber - 1) / 26;
                }

                return ans;
            }

            public static async Task Main(string[] args)
            {
                Program solution = new Program();

                Console.WriteLine("Enter the column number:");

                // Simulate asynchronous user input reading with artificial delay
                await Task.Run(async () =>
                {
                    await Task.Delay(100); // Simulating a delay of 1 second
                    int columnNumber = Convert.ToInt32(Console.ReadLine());

                    string title = solution.ConvertToTitle(columnNumber);
                    Console.WriteLine("Excel column title: " + title);
                });
            }
        }
    }
    

