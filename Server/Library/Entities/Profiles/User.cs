using Library.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class User : Profile
    {
        #region Local Fields
        private Genders gender;
        private string lastname;
        #endregion

        #region Properties
        public Roles Role { get; set; }
        public string SSID { get; set; }
        public string Firstname { get; set; }
        public DateTime? BirthDate { get; set; }
        public int DiscountRate { get; set; }
        #endregion

        #region Property Modifiers
        public Genders Gender
        {
            get { return gender; }
            set
            {
                gender = value;

                if (value == Genders.Male)
                {
                    if (this.Role == Roles.Employee)
                    {
                        base.Picture = "http://www.aznxt.com/images/user.png";
                    }
                    else
                    {
                        base.Picture = "https://mezuhost.com/tanitim/img/user-header.png";
                    }
                }
                else
                {
                    base.Picture = "https://image.flaticon.com/icons/png/512/206/206897.png";
                }
            }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; base.Title = this.GetName(); }
        }
        #endregion

        public User()
        {
            this.Initialize();
        }
        public override void Initialize()
        {
            base.Initialize();

            this.Role = Roles.Customer;
            this.IsActive = false;
        }

        private string GetName()
        {
            return $"{this.Firstname} {this.Lastname}";
        }
    }
}
