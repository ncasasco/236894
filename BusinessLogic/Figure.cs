using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Figure
    {
        private string owner;
        private string name;
        private double radius;

        public string Owner {
            get => owner;

            set
            {
                owner = value;
            }
        }

        public string Name
        {
            get => name;

            set
            {
                name = value;
            }
        }

        public double Radius
        {
            get => radius;

            set
            {
                if (value <= 0)
                    throw new BusinessLogicException($"Radius has to be greater than 0");
                else
                    radius = value;
            }
        }

    }
}
