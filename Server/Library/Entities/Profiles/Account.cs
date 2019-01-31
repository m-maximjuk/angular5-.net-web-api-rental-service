using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Account : Model
    {
        #region Relationships
        [ForeignKey("UserID")]
        public virtual User User { get; set; }
        public int UserID { get; set; }
        #endregion

        #region Properties
        public string Username { get; set; }
        public string Password { get; set; }
        #endregion

        public Account()
        {
            base.Initialize();
            this.User = new User();
        }
    }
}
