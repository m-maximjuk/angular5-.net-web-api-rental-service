using System;
using System.ComponentModel.DataAnnotations;

namespace Library.Entities
{
    public abstract class Model
    {
        #region Properties
        [Key]
        public int ID { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual DateTime? Created { get; set; }
        public virtual string Title { get; set; }
        #endregion  

        public virtual void Initialize()
        {
            this.Created = DateTime.Now;
            this.IsActive = true;
        }
    }
}
