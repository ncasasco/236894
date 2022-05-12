//using BusinessLogic.Exceptions;
using System;

namespace BusinessLogic
{
    public class Producer
    {
        private string password;
        private string mail;
        private string firstName;
        private string lastName;
        public const int minimumPasswordLength = 5;
        public const int MailMinLength = 6;
        public const int MailMaxLength = 30;
        public const int FirstNameMinLength = 2;
        public const int FirstNameMaxLength = 30;
        public const int LastNameMinLength = 2;
        public const int LastNameMaxLength = 60;

        public string Mail
        {
            get => mail;
            set
            {
                if (value?.Length < MailMinLength || value?.Length > MailMaxLength)
                    throw new BusinessLogicException($"Producer mail length must be between {MailMinLength} and {MailMaxLength} characters");
                else 
                    mail = value;
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if (value?.Length < minimumPasswordLength)
                    throw new BusinessLogicException($"Password should have a minimum of {minimumPasswordLength} characters");
                else
                    password = value;
            }
        }
        public string FirstName
        {
            get => firstName;
            set
            {
                if (value?.Length < FirstNameMinLength || value?.Length > FirstNameMaxLength)
                    throw new BusinessLogicException($"First name length must be between {FirstNameMinLength} and {FirstNameMaxLength} characters");
                else
                    firstName = value;
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                if (value?.Length < LastNameMinLength || value?.Length > LastNameMaxLength)
                    throw new BusinessLogicException($"Last name length must be between {LastNameMinLength} and {LastNameMaxLength} characters");
                else
                    lastName = value;
            }
        }
        
        public bool Equals(Producer other) => other != null && other.Mail.Equals(this.Mail);

        public Producer DeepClone()
        {
            return new Producer()
            {
                mail = this.Mail,
                password = this.Password,
                firstName = this.FirstName,
                lastName = this.LastName,
            };
        }

    }
}