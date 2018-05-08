using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBox
{
    internal class Box
    {
        private double lenght;

        public double Lenght
        {
            get { return lenght; }
            set
            {
                ValidateSize(value, "Lenght");
                lenght = value;
            }
        }

        private double height;

        public double Height
        {
            get { return height; }
            set
            {
                ValidateSize(value, "Height");
                height = value;
            }
        }

        private double width;

        public double Width
        {
            get { return width; }
            set
            {

                ValidateSize(value, "Widht");
                width = value;
            }
        }

        public Box(double lenght, double width, double height)
        {
            Lenght = lenght;
            Width = width;
            Height = height;
        }


        public double Surface(double lenght, double height, double width) {

            double surface = 2 * lenght * width + 2 * lenght * height + 2 * width * height;
            return surface;
        }

        public double LateralSurface(double lenght, double height, double width)
        {

            double lateralSurface = 2 * lenght * width + 2 * width * height;
            return lateralSurface;
        }

        public double Volume(double lenght, double height, double width)
        {

            double volume = lenght * width * height;
            return volume;
        }

        private void ValidateSize(double fieldSize, string fieldName)
        {
            if (fieldSize <= 0 )
            {
                throw new ArgumentException($"{fieldName} cannot be zero or negative.");
            }
        }

    }
}
