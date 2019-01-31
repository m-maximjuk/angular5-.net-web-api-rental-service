using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Order : Profile
    {
        #region Relationships
        [ForeignKey("VehicleID")]
        public Vehicle Vehicle { get; set; }
        public int VehicleID { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }
        public int UserID { get; set; }
        [ForeignKey("PriceID")]
        public Price Price { get; set; }
        public int PriceID { get; set; }
        #endregion

        #region Properties
        public DateTime? StartDate { get; set; }
        public DateTime? FinalDate { get; set; }
        public DateTime? Returned { get; set; }
        public bool IsOverdue { get; set; }
        #endregion

        public Order()
        {
            this.Initialize();
        }
        public override void Initialize()
        {
            base.Initialize();
            this.IsOverdue = false;
        }
    }
}
