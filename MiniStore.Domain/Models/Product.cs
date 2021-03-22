using System;
using System.Collections.Generic;
using System.Text;

namespace MiniStore.Domain.Models
{
    public class Product
    {
        #region Constructors
        private Product() { }

        public Product(string name, string description, double price, int category)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.CategoryID = category;
        }
        #endregion

        #region Properties
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string Description { get; set; }

        public double Price { get; set; }

        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }
        #endregion 
    }
}
