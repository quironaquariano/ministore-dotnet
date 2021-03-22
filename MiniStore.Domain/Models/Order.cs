using System;
using System.Collections.Generic;
using System.Text;

namespace MiniStore.Domain.Models
{
    public class Order
    {

        #region Properties
        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public ICollection<Product> Products { get; set; }
        #endregion
    }
}
