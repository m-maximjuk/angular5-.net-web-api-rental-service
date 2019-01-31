using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entities
{
    public abstract class Profile : Model
    {
        #region Properties
        public string Description { get; set; }
        public string Picture { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public virtual DateTime? ActiveSince { get; set; }
        public virtual DateTime? ActiveLast { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        #endregion

        #region Property Modifiers
        public override bool IsActive
        {
            get => base.IsActive;
            set
            {
                base.IsActive = value;

                if (value) { this.ActiveSince = DateTime.Now; }
                else { this.ActiveLast = DateTime.Now; }
            }                
        }
        #endregion

        public Profile()
        {
            this.Initialize();
        }

        public override void Initialize()
        {
            base.Initialize();
        }
    }
}
