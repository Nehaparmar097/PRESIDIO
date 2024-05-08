using RequestTrackerEmployees.Model;
using System.Reflection;

namespace RequestTrackerEmployees
{
    internal class Program
    {
        static void Main(string[] args)
        {   //this one is for adding data in the db
            /* Area area = new Area();
             area.Area1 = "nOnO";
             area.Zipcode = "44332";
             EmployeeTrackerdbContext context = new EmployeeTrackerdbContext();
             context.Areas.Add(area);
             context.SaveChanges();
             Console.WriteLine("addeed successfully");*/

            //retriving data from db
            EmployeeTrackerdbContext context = new EmployeeTrackerdbContext();

            /* var areas = context.Areas.ToList();
             foreach (var area in areas)
             {
                 Console.WriteLine(area.Area1 + " " + area.Zipcode);
             }*/

            //upadation code
            /*var areas = context.Areas.ToList();
            var area = areas.SingleOrDefault(a => a.Area1 == "POPO");
            area.Zipcode = "00000";
            context.Areas.Update(area);
            context.SaveChanges();*/
            //delition code
            var areas = context.Areas.ToList();
            var area = areas.SingleOrDefault(a => a.Area1 == "POPO");
            context.Areas.Remove(area);
            context.SaveChanges();
            foreach (var a in areas)
            {
                Console.WriteLine(a.Area1 + " " + a.Zipcode);
            }

        }
    }
}
//Scaffold - DbContext "data dource=QL1TE6V\SQLEXPRESS;Integrated Security=true;Initial Catalog=EmployeeTrackerdb" Microsoft.EntityFrameworkCore.SqlServer - OutputDir Model

//Scaffold-DbContext "data source=DESKTOP-QL1TE6V\SQLEXPRESS;Integrated security=true;Initial Catalog=EmployeeTrackerdb;"Microsoft.EntityFrameworkCore.SqlServer -OutputDir Model