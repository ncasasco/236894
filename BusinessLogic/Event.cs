using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Event
    {
        private string name;
        private string description;
        private string adress;
        private string picturePath;
        public string category { get; set; }
        public bool isOnline { get; set; }
        public IList<Ticket> tickets { get; set; }
        public IList<Tuple<DateTime, DateTime>> schedule { get; set; }

        public const int NameMinLength = 5;
        public const int NameMaxLength = 110;
        public const int DescriptionMinLength = 5;
        public const int DescriptionMaxLength = 250;
        public const int AdressMinLength = 5;
        public const int AdressMaxLength = 50;

        [Key]
        public string Name
        {
            get => name;
            set
            {
                if (value?.Length < NameMinLength || value?.Length > NameMaxLength)
                    throw new BusinessLogicException($"Name length must be between {NameMinLength} and {NameMaxLength} characters");
                else
                    name = value;
            }
        }

        public string Description
        {
            get => description;
            set
            {
                if (value?.Length < DescriptionMinLength || value?.Length > DescriptionMaxLength)
                    throw new BusinessLogicException($"Name length must be between {DescriptionMinLength} and {DescriptionMaxLength} characters");
                else
                    name = value;
            }
        }
        public string Adress
        {
            get => adress;
            set
            {
                if (value?.Length < AdressMinLength || value?.Length > AdressMaxLength)
                    throw new BusinessLogicException($"Name length must be between {AdressMinLength} and {AdressMaxLength} characters");
                else
                    name = value;
            }
        }

        [DataType(DataType.Url)]
        public string PicturePath
        {
            get => picturePath;
            set
            {
                if (value?.Length <= 0)
                    throw new BusinessLogicException("Please pick a profile picture");
                picturePath = value;
            }
        }

        public Event DeepClone()
        {
            return new Event()
            {
                name = this.Name,
                description = this.Description,
                adress = this.Adress,
                picturePath = this.PicturePath,
                category = this.category,
                isOnline = this.isOnline,
                tickets = this.tickets,
                schedule = this.schedule,
            };
        }
    }
}
