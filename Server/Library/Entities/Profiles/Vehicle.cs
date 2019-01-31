using Library.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Vehicle : Profile
    {
        #region Relationships
        [ForeignKey("BranchID")]
        public Branch Branch { get; set; }
        public int BranchID { get; set; }
        [ForeignKey("ManufacturerID")]
        public Manufacturer Manufacturer { get; set; }
        public int ManufacturerID { get; set; }
        #endregion

        #region Properties
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Transmission { get; set; }
        public string Color { get; set; }
        public string LicenseID { get; set; }
        public int Mileage { get; set; }
        public int Owners { get; set; }
        public int Year { get; set; }
        public int MarketPrice { get; set; }
        #endregion

        public Vehicle()
        {
            this.Initialize();
        }
        public override void Initialize()
        {
            base.Initialize();
        }

        public string GetTitle()
        {
            return $"{this.Year} {this.Color} {this.Brand} {this.Model}";
        }
    }
}
