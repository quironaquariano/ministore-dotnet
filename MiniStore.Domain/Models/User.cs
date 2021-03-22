using MinStore.Recourses;
using MinStore.Recourses.Validation;
using MinStore.Resourses.Resource;
using System;


namespace MiniStore.Domain.Models
{

    public class User
    {
        #region Constructor
        private User() { }

        public User(string name, string surname)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Surname = surname;
        }
        #endregion

        #region Properties
        public Guid  Id { get; private set; }

        public string Name { get;  private set; }

        public string Surname { get; private set; }

        public string Email { get; private set; }

        public string Password { get; private set; }
        #endregion

        #region Methods
        public void Validate()
        {
            PasswordAssertionConcern.AssertIsValid(this.Password);
            AssertionConcern.AssertArgumentLength(this.Name, 4, 50, Errors.InputOutOfRange);
            EmailAssertionConcern.AssertIsValid(this.Email);
        }

        public void SetPassword(string password, string confirmPassword)
        {
            AssertionConcern.AssertArgumentNotNull(password, Errors.InvalidEmail);
            AssertionConcern.AssertArgumentNotNull(confirmPassword, Errors.InvalidEmail);
            AssertionConcern.AssertArgumentEquals(password, confirmPassword, Errors.PwNotMatch);
            this.Password = PasswordAssertionConcern.Encrypt(password);
        }
        #endregion
    }




}
