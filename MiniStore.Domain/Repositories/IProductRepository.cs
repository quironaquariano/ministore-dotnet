using MiniStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniStore.Domain.Repositories
{
    public interface IProductRepository
    {
        Product Get(int Id);

        ICollection<Product> GetAll();

        void Create(Product product);

        void Update(Product product);

        void Delete(Product product);

    }
}
