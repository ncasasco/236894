using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Material
    {
        private string owner;
        private string name;
        private int redMaterial;
        private int greenMaterial;
        private int blueMaterial;

        public string Owner
        {
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
                if (value?.Length <= 0)
                    throw new BusinessLogicException($"Name should not be empty");
                else
                    name = value;
            }
        }

        public int RedMaterial
        {
            get => redMaterial;

            set
            {
                if (value < 0 || value > 255)
                    throw new BusinessLogicException($"Value has to be between 0 and 255");
                else
                    redMaterial = value;
            }
        }
        public int GreenMaterial
        {
            get => greenMaterial;

            set
            {
                if (value < 0 || value > 255)
                    throw new BusinessLogicException($"Value has to be between 0 and 255");
                else
                    redMaterial = value;
            }
        }
        public int BlueMaterial
        {
            get => blueMaterial;

            set
            {
                if (value < 0 || value > 255)
                    throw new BusinessLogicException($"Value has to be between 0 and 255");
                else
                    blueMaterial = value;
            }
        }
    }
}
