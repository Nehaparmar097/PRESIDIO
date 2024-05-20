using LINQ.Model;

namespace LINQ
{
    internal class Program
    {
        public static void PrintTheBooksPublisherwise()
        {
            using (var context = new pubsContext())
            {
                var books = context.Sales.GroupBy(s => s.TitleId, s => s, (titleId, sales) => new{
                       TitleId = titleId,
                       Sales = sales.ToList()
                   })
                   .ToList();
                foreach (var group in books)
                {
                    Console.WriteLine($"TitleId: {group.TitleId}");
                    Console.WriteLine("Sales:");
                    foreach (var sale in group.Sales)
                    {
                        Console.WriteLine($"  Quantity: {sale.Qty}, OrderId: {sale.OrdNum}");
                    }
                    Console.WriteLine();
                }
            }
        }
        /* void PrintTheBooksPulisherwise()
         {
             pubsContext context = new pubsContext();
             var books = context.sale
                         .GroupBy(t => t.PubId, t => t, (pid, title) => new { Key = pid, TitleCount = title.Count(), TitleNames = title.ToList() });

             foreach (var book in books)
             {
                 Console.Write(book.Key);
                 Console.WriteLine(" - " + book.TitleCount);
                 Console.WriteLine("BookNames");
                 foreach (var title in book.TitleNames)
                 {
                     Console.WriteLine(title.Title1);
                 }
             }
         }*/
        void PrintNumberOfBooksFromType(string type)
        {
            pubsContext context = new pubsContext();
            var bookCount = context.Titles.Where(t => t.Type == type).Count();
            Console.WriteLine($"There are {bookCount} in the type {type}");
        }
        void PrintAuthorNames()
        {
            pubsContext context = new pubsContext();
            var authors = context.Authors.ToList();
            foreach (var author in authors)
            {
                Console.WriteLine(author.AuFname + " " + author.AuLname);
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            //program.PrintAuthorNames();
           // program.PrintNumberOfBooksFromType("mod_cook");
            PrintTheBooksPublisherwise();
        }
    }
}

//Scaffold-DbContext "Data Source=DESKTOP-QL1TE6V\SQLEXPRESS;Integrated Security=true;Initial Catalog=pubs" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Model
