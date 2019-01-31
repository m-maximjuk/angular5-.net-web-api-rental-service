using Library.Entities;
using Library.Enums;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Data.Context.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true; // Intended Specifically For Building Purposes, Maybe Removed Later
            ContextKey = "Data.Migrations.Configuration";
        }

        protected override void Seed(Data.Context.DataContext context)
        {
            // Generate Branches
            #region Branches
            if (!(context.Branches.Count() > 0))
            {
                for (int i = 1; i < MyEnum<Locations>.GetLength(); i++)
                {
                    context.Branches.AddOrUpdate(new Branch()
                    {
                        Title = MyEnum<Locations>.Stringify((Locations)i),
                        Address = $"{(new Random(i).Next(1, 150))} Industrial Area Rd. {MyEnum<Locations>.Stringify((Locations)i)}, Israel",
                        Phone = $"072-{new Random(i).Next(1000000, 9999999)}",
                        Email = $"{Convert.ToString((Locations)i)}@RentalClient.co.il",
                        Description = $"{MyEnum<Locations>.Stringify((Locations)i)} Location",
                    });
                }
            }
            #endregion
            // Generate Manufacturers
            #region Manufacturers
            if (!(context.Manufacturers.Count() > 0))
            {
                for (int i = 1; i < MyEnum<Manufacturers>.GetLength(); i++)
                {
                    context.Manufacturers.AddOrUpdate(new Manufacturer()
                    {
                        Company = (Manufacturers)i,
                        Picture = MyEnum<Manufacturers>.GetDetails((Manufacturers)i).Picture,
                        Description = MyEnum<Manufacturers>.GetDetails((Manufacturers)i).Description,
                        Title = MyEnum<Manufacturers>.Stringify((Manufacturers)i)
                    });
                }
            }
            #endregion
            // Generate Vehicles
            #region Vehicles
            if (context.Branches.Count() > 0 && !(context.Vehicles.Count() > 0))
            {
                for (int i = 1; i < MyEnum<Vehicles>.GetLength(); i++)
                {
                    var company = MyEnum<Vehicles>.GetDetails((Vehicles)i).Manufacturer;

                    context.Vehicles.AddOrUpdate(new Vehicle()
                    {
                        Branch = context.Branches.ToList().ElementAt(new Random(i).Next(context.Branches.ToList().Count())),
                        Manufacturer = context.Manufacturers.Single(brand => brand.Company == company),
                        Brand = MyEnum<Manufacturers>.Stringify(MyEnum<Vehicles>.GetDetails((Vehicles)i).Manufacturer),
                        Description = MyEnum<Vehicles>.GetDetails((Vehicles)i).Description,
                        Picture = MyEnum<Vehicles>.GetDetails((Vehicles)i).Picture,
                        Model = MyEnum<Vehicles>.Stringify((Vehicles)i),
                        Transmission = MyEnum<Transmissions>.Stringify((Transmissions)new Random(i).Next(1, MyEnum<Transmissions>.GetLength())),
                        Color = MyEnum<Colors>.Stringify((Colors)new Random(i).Next(1, MyEnum<Colors>.GetLength())),
                        LicenseID = $"{new Random(i).Next(1000000, 9999999)}",
                        Mileage = new Random(i).Next(10000),
                        Owners = new Random(i).Next(0, 3),
                        Year = new Random(i).Next(2012, DateTime.Now.Year),
                        MarketPrice = new Random(i).Next(80000, 260000),
                    });
                }
            }
            #endregion
            // Generate Accounts
            context.Accounts.AddOrUpdate(new Account()
            {
                Username = "YoniProbeh",
                Password = "Password",
            });
        }
    }
}