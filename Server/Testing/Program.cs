using Library.Entities;
using Library.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        public static void Method()
        {
            var items = new List<Vehicle>();

            for (int i = 1; i < 10; i++)
            {
                items.Add(new Vehicle()
                {
                    Description = MyEnum<Vehicles>.GetDetails((Vehicles)i).Description,
                    Title = MyEnum<Vehicles>.Stringify((Vehicles)i),
                    Model = (Vehicles)i,
                    Transmission = (Transmissions)new Random(i).Next(0, MyEnum<Transmissions>.GetLength()),
                    Color = (Colors)new Random(i).Next(0, MyEnum<Colors>.GetLength()),
                    LicenseID = $"{new Random(i).Next(1000000, 9999999)}",
                    Mileage = new Random(i).Next(10000),
                    Owners = new Random(i).Next(0, 3),
                    Year = new Random(i).Next(2012, DateTime.Now.Year),
                    MarketPrice = new Random(i).Next(80000, 260000),
                });
            }
        }

        static void Main(string[] args)
        {
            for (int i = 1; i < MyEnum<Vehicles>.GetLength(); i++)
            {
                Console.WriteLine(MyEnum<Vehicles>.GetDetails((Vehicles)i).Manufacturer);
            }
        }

        public static void DateTest()
        {
            var order = new Order()
            {
                StartDate = DateTime.Now,
                FinalDate = DateTime.Now.AddDays(5),
                BasePrice = 98,
            };

            Console.WriteLine($"Start Date: {order.StartDate}");
            Console.WriteLine($"Final Date: {order.FinalDate}");
            Console.WriteLine($"Base Price: {order.BasePrice}");
            order.GetPrice();
            Console.WriteLine($"Subtotal: {order.SubTotal}");
        }
    }
}

public class Order
{

    #region Properties
    public DateTime? StartDate { get; set; }
    public DateTime? FinalDate { get; set; }
    public DateTime? Returned { get; set; }
    public double BasePrice { get; set; }
    public double SubTotal { get; set; }
    public double TotalDue { get; set; }
    public double TotalPayed { get; set; }
    #endregion

    public Order()
    {
        
    }

    public void GetPrice()
    {
        // Subtracted TimeSpan Result (FinalDate - Start Date)
        TimeSpan result = this.FinalDate.Value.Subtract(this.StartDate.Value);
        // Total Order Days
        int orderDays = result.Days;
        this.SubTotal = this.BasePrice * orderDays;
    }
}
