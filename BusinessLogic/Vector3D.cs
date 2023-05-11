using System;


namespace BusinessLogic
{
    public class Vector3D
    {

        private const int MAX_PRIMARY_VALUE = 255;
        private const int MIN_PRIMARY_VALUE = 0;
        private const int MAX_PERCENTAGE = 100;
        private const int MIN_PERCENTAGE = 0;


        private double redPercentage;
        private double greenPercentage;
        private double bluePercentage;



        public double RedPercentage
        {
            get => redPercentage;
            set
            {

                if (value < MIN_PERCENTAGE || value > MAX_PERCENTAGE)
                    throw new ArgumentException("Red percentage out of range");
                else
                    redPercentage = value;
            }
        }
        public double GreenPercentage
        {
            get => greenPercentage;
            set
            {

                if (value < MIN_PERCENTAGE || value > MAX_PERCENTAGE)
                    throw new ArgumentException("Green percentage out of range");
                else
                    greenPercentage = value;
            }
        }
        public double BluePercentage
        {
            get => bluePercentage;
            set
            {

                if (value < MIN_PERCENTAGE || value > MAX_PERCENTAGE)
                    throw new ArgumentException("Blue percentage out of range");
                else
                    bluePercentage = value;
            }
        }


        public Vector3D(double red, double green, double blue)
        {
            if (red < MIN_PERCENTAGE || red > MAX_PERCENTAGE)
                throw new ArgumentException("Red percentage out of range");
            else if (green < MIN_PERCENTAGE || green > MAX_PERCENTAGE)
                throw new ArgumentException("Green percentage out of range");
            else if (blue < MIN_PERCENTAGE || blue > MAX_PERCENTAGE)
                throw new ArgumentException("Blue percentage out of range");
            else
                this.redPercentage = red;
            this.greenPercentage = green;
            this.bluePercentage = blue;
        }


        public Vector3D()
        {
            this.redPercentage = RedPercentage;
            this.greenPercentage = GreenPercentage;
            this.bluePercentage = BluePercentage;
        }


        public double Red()
        {
            return Math.Abs(Math.Round(this.redPercentage * MAX_PRIMARY_VALUE)); // pasamos el porcentaje de color a un número entre 0 y 255
        }
        public double Green()
        {
            return Math.Abs(Math.Round(this.greenPercentage * MAX_PRIMARY_VALUE)); // pasamos el porcentaje de color a un número entre 0 y 255
        }
        public double Blue()
        {
            return Math.Abs(Math.Round(this.bluePercentage * MAX_PRIMARY_VALUE)); // pasamos el porcentaje de color a un número entre 0 y 255
        }
        public Vector3D AddVector(Vector3D vector3d)
        {
            return new Vector3D(this.redPercentage + vector3d.redPercentage, this.greenPercentage + vector3d.greenPercentage, this.BluePercentage + vector3d.BluePercentage);
        }

        public Vector3D SubtractVector(Vector3D vector3d)
        {
            return new Vector3D(this.redPercentage - vector3d.redPercentage, this.greenPercentage - vector3d.greenPercentage, this.BluePercentage - vector3d.BluePercentage);
        }

        public Vector3D MultiplyVector(int iCount)
        {
            return new Vector3D(this.redPercentage * iCount, this.greenPercentage * iCount, this.BluePercentage * iCount);
        }

        public Vector3D DivideVector(int iCount)
        {
            if (iCount == 0) throw new ArgumentException("Can't divide by 0");

            return new Vector3D(this.redPercentage / iCount, this.greenPercentage / iCount, this.BluePercentage / iCount);
        }

        public void AddToVector(Vector3D vector3d)
        {

            this.redPercentage += vector3d.RedPercentage;
            this.greenPercentage += vector3d.GreenPercentage;
            this.bluePercentage += vector3d.BluePercentage;
        }
        public void SubtractFromVector(Vector3D vector3d)
        {

            this.redPercentage -= vector3d.RedPercentage;
            this.greenPercentage -= vector3d.GreenPercentage;
            this.bluePercentage -= vector3d.BluePercentage;
        }
        public void ScaleDownBy(int iCount)
        {

            this.redPercentage /= iCount;
            this.greenPercentage /= iCount;
            this.bluePercentage /= iCount;
        }

        public Vector3D GetUnit()
        {
            return this.DivideVector(this.Length());
        }

        public double VectorDot(Vector3D vector3d)
        {
            return (this.redPercentage * vector3d.RedPercentage) + (this.bluePercentage * vector3d.BluePercentage) + (this.greenPercentage * vector3d.GreenPercentage);
        }

        public Vector3D cross(Vector3D vector3d)
        {
            var x = this.greenPercentage * vector3d.BluePercentage - this.bluePercentage * vector3d.GreenPercentage;
            var y = this.bluePercentage * vector3d.RedPercentage - this.RedPercentage * vector3d.BluePercentage;
            var z = this.redPercentage * vector3d.GreenPercentage - this.GreenPercentage * vector3d.redPercentage;
            return new Vector3D(x, y, z);
        }

        private double SquaredLength()
        {
            return (this.redPercentage * this.redPercentage) + (this.bluePercentage * this.bluePercentage) + (this.greenPercentage * this.greenPercentage);
        }
        
        private int Length()
        {
            return Convert.ToInt32(Math.Sqrt(this.SquaredLength()));
        }

    }

}



