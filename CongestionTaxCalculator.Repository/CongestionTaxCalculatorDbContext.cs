
using CongestionTaxCalculator.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace CongestionTaxCalculator.Repository
{
    public class CongestionTaxCalculatorDbContext : DbContext
    {
        public CongestionTaxCalculatorDbContext(DbContextOptions<CongestionTaxCalculatorDbContext> options) : base(options)
        {
        }

        public DbSet<CongestionTax> CongestionTaxes { get; set; }

        public DbSet<TaxExemptVehicle> TaxExemptVehicles { get; set; }

        public DbSet<TaxExceptDate> TaxExceptDates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CongestionTax>().HasData(
                new CongestionTax { Id = 1, StartTime = new TimeSpan(06, 00, 00), EndTime = new TimeSpan(06, 29, 00), Amount = 8 },
                new CongestionTax { Id = 2, StartTime = new TimeSpan(06, 30, 00), EndTime = new TimeSpan(06, 59, 00), Amount = 13 },
                new CongestionTax { Id = 3, StartTime = new TimeSpan(07, 00, 00), EndTime = new TimeSpan(07, 59, 00), Amount = 18 },
                new CongestionTax { Id = 4, StartTime = new TimeSpan(08, 00, 00), EndTime = new TimeSpan(08, 29, 00), Amount = 13 },
                new CongestionTax { Id = 5, StartTime = new TimeSpan(08, 30, 00), EndTime = new TimeSpan(14, 59, 00), Amount = 8 },
                new CongestionTax { Id = 6, StartTime = new TimeSpan(15, 00, 00), EndTime = new TimeSpan(15, 29, 00), Amount = 13 },
                new CongestionTax { Id = 8, StartTime = new TimeSpan(15, 30, 00), EndTime = new TimeSpan(16, 59, 00), Amount = 18 },
                new CongestionTax { Id = 9, StartTime = new TimeSpan(17, 00, 00), EndTime = new TimeSpan(17, 59, 00), Amount = 13 },
                new CongestionTax { Id = 10, StartTime = new TimeSpan(18, 00, 00), EndTime = new TimeSpan(18, 29, 00), Amount = 8 },
                new CongestionTax { Id = 11, StartTime = new TimeSpan(18, 30, 00), EndTime = new TimeSpan(05, 59, 00), Amount = 0 }
                );

            modelBuilder.Entity<TaxExemptVehicle>().HasData(
                new TaxExemptVehicle { Id = 1, VehicleName = "Emergency Vehicles", VehicleCode = "EmergencyVehicles" },
                new TaxExemptVehicle { Id = 2, VehicleName = "Busses", VehicleCode = "Busses" },
                new TaxExemptVehicle { Id = 3, VehicleName = "Diplomat Vehicles", VehicleCode = "DiplomatVehicles" },
                new TaxExemptVehicle { Id = 4, VehicleName = "Motorcycles", VehicleCode = "Motorcycles" },
                new TaxExemptVehicle { Id = 5, VehicleName = "Military Vehicles", VehicleCode = "MilitaryVehicles" },
                new TaxExemptVehicle { Id = 6, VehicleName = "Foreign Vehicles", VehicleCode = "ForeignVehicles" }
                );


            List<TaxExceptDate> taxExceptDates = new List<TaxExceptDate>();

            List<DateTime> allDates = new List<DateTime>
            {
               new DateTime(2013, 1, 1),
               new DateTime(2013, 3, 28),
               new DateTime(2013, 3, 29),
               new DateTime(2013, 4, 1),
               new DateTime(2013, 4, 30),
               new DateTime(2013, 5, 1),
               new DateTime(2013, 5, 8),
               new DateTime(2013, 5, 9),
               new DateTime(2013, 6, 5),
               new DateTime(2013, 6, 6),
               new DateTime(2013, 6, 21),
               new DateTime(2013, 11, 1),
               new DateTime(2013, 12, 24),
               new DateTime(2013, 12, 25),
               new DateTime(2013, 12, 26),
               new DateTime(2013, 12, 31),
            };

            allDates.AddRange(this.GetAllDays(2013, 7));
            allDates.AddRange(this.GetAllSatAndSuns(2013));

            for (int i = 0; i < allDates.Count; i++)
            {
                taxExceptDates.Add(new TaxExceptDate { Id = i + 1, Date = allDates[i] });
            }


            modelBuilder.Entity<TaxExceptDate>().HasData(taxExceptDates.ToArray());
        }

        private List<DateTime> GetAllSatAndSuns(int year)
        {
            List<DateTime> Dates = new List<DateTime>();

            DateTime Date = new DateTime(year, 1, 1);

            while (Date.Year == year)
            {
                if ((Date.DayOfWeek == DayOfWeek.Saturday) ||
                (Date.DayOfWeek == DayOfWeek.Sunday))
                    Dates.Add(Date);
                Date = Date.AddDays(1);
            }
            return Dates;
        }

        private List<DateTime> GetAllDays(int year, int month)
        {
            List<DateTime> Dates = new List<DateTime>();

            DateTime Date = new DateTime(year, month, 1);

            while (Date.Year == year && Date.Month == month)
            {
                Dates.Add(Date);

                Date = Date.AddDays(1);
            }
            return Dates;
        }


    }
}
