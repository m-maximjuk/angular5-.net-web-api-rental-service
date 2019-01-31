using Library.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Manufacturer : Profile
    {
        public Manufacturers Company { get; set; }

        public Manufacturer()
        {
            this.Initialize();
        }
        public override void Initialize()
        {
            base.Initialize();
        }
    }
}
