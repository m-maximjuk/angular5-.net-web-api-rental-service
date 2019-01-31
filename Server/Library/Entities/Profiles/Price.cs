using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Price : Model
    {
        #region Properties
        public double BasePrice { get; set; }
        public double SubTotal { get; set; }
        public double TotalDue { get; set; }
        public double TotalPayed { get; set; }
        #endregion

        public Price()
        {
            this.Initialize();
        }
        public override void Initialize()
        {
            base.Initialize();
        }
    }
}
