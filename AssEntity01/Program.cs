using AssEntity01.Context;
using AssEntity01.Models;
using Microsoft.EntityFrameworkCore;

namespace AssEntity01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            #region CRUD
            using AppDbContext context = new AppDbContext();
            #region Insert (create)
            //AirLine airLine1 = new AirLine
            //{
            //    Name = "egyptAir",
            //    Address = "cairo",
            //    Cont_Person = 500
            //};

            //AirLine airLine2 = new AirLine
            //{
            //    Name = "fly emirates",
            //    Address = "dubai",
            //    Cont_Person = 1000
            //};

            //context.Add(airLine1);
            //context.Add(airLine2);

            //Console.WriteLine(context.Entry(airLine1).State);


            //context.SaveChanges();
            //Console.WriteLine(context.Entry(airLine1).State);

            #endregion

            #region Read (select)

            //var airline = context.AirLine.ToList();

            //foreach (var item in airline)
            //{
            //    Console.WriteLine(item.Name);
            //}
            #endregion

            #region Update 

            //var airline = context.AirLine.FirstOrDefault();
            //Console.WriteLine(context.Entry(airline).State);

            //airline.Name = "qatar Airways";
            //Console.WriteLine(context.Entry(airline).State);

            //context.SaveChanges();
            //Console.WriteLine(context.Entry(airline).State);
            #endregion

            #region delete

            //var airline = context.AirLine.FirstOrDefault(a=> a.Id == 3);
            //Console.WriteLine(context.Entry(airline).State);

            //context.Remove(airline);
            //Console.WriteLine(context.Entry(airline).State);

            //context.SaveChanges();
            //Console.WriteLine(context.Entry(airline).State);
            #endregion

            #region Create
            //AirCraft airCraft1 = new AirCraft
            //{
            //    Capacity = "5000",
            //    Model = "airBus",
            //    Maj_Pilot = "mohamed",
            //    Assistant = "mahmoud",
            //    Host1 = "salma",
            //    Host2 = "habiba",
            //    AirLineId = 1
            //};

            //context.Add(airCraft1);
            //Console.WriteLine(context.Entry(airCraft1).State);

            //context.SaveChanges();
            //Console.WriteLine(context.Entry(airCraft1).State);

            #endregion

            #region select
            //var aircraft = context.AirCrafts.Include(a=> a.AirLine).FirstOrDefault();

            //Console.WriteLine($"aircraft name = {aircraft.Model} :: airline name = {aircraft.AirLine.Name}");


            #endregion

            #endregion
        }
    }
}
