using System;
using System.Collections.Generic;
using System.Text;

namespace MiniStore.Domain.Models
{
    public class Category
    {
        #region Constructor
        private Category() { }

        public Category(string name)
        {
            this.Name = name;
        }
        #endregion

        #region Properties
        public int Id { get; set; }

        public string Name { get; set; }
        #endregion
    }
}
