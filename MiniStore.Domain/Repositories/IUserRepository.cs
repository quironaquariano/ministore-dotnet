using MiniStore.Domain.Models;
using System;
using System.Collections.Generic;

namespace MiniStore.Domain.Services
{
    interface IUserRepository
    {
        ICollection<User> GetAllUsers();

        User GetUser(string Email);

        User GetUser(Guid Id);

        void CreateUser(User user);

        void UpdateUser(User user);

        void DeleteUser(User user);


    }
}
