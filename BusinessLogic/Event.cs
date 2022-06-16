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
        private string category;
        private bool isOnline;
        private IList<Ticket> tickets;
        private IList<Tuple<DateTime, DateTime>> schedule;

        public const int NameMinLength = 5;
        public const int NameMaxLength = 110;
        public const int DescriptionMinLength = 5;
        public const int DescriptionMaxLength = 250;


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
    }
}
