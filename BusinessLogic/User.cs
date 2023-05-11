//using BusinessLogic.Exceptions;
using System;

namespace BusinessLogic
{
    public class User
    {
        private string username;
        private string password;
        private DateTime registrationDate;

        public const int UsernameMinLength = 3;
        public const int UsernameMaxLength = 20;
        public const int PasswordMinLength = 5;
        public const int PasswordMaxLength = 25;

        public string Username
        {
            get => username;
            set
            {
                if (value?.Length < UsernameMinLength || value?.Length > UsernameMaxLength)
                    throw new BusinessLogicException($"Username length must be between {UsernameMinLength} and {UsernameMaxLength} characters");
                else
                    username = value;
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if (value?.Length < PasswordMinLength || value?.Length > PasswordMaxLength)
                    throw new BusinessLogicException($"Password length must be between {PasswordMinLength} and {PasswordMaxLength} characters");
                else
                    password = value;
            }
        }

        public DateTime RegistrationDate
        {
            get => registrationDate;
            set
            {
                registrationDate = value;
            }
        }

        public bool Equals(User other) => other != null && other.Username.Equals(this.Username);

        public User DeepClone()
        {
            return new User()
            {
                username = this.Username,
                password = this.Password,
                registrationDate = this.RegistrationDate,
            };
        }
    }
}