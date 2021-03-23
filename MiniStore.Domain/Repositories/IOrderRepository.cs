using MiniStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniStore.Domain.Repositories
{
    public interface IOrderRepository
    {
        ICollection<Order> GetAll();

        ICollection<Order> GetUserOrders(User user);

        Order GetOrder(Guid Id);

        void Create(Order order);

        void Update(Order order);

        void Delete(Order order);


    }
}
