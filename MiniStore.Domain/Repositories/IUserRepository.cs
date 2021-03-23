using MiniStore.Domain.Models;
using System;
using System.Collections.Generic;

namespace MiniStore.Domain.Services
{
    public interface IUserRepository
    {
        ICollection<User> GetAll();

        User Get(string Email);

        User Get(Guid Id);

        void Create(User user);

        void Update(User user);

        void Delete(User user);


    }
}
