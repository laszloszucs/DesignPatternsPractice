using System;

namespace SimpleFactory.Door
{
    internal class WoodenDoor: IDoor
    {
        protected double Width;
        protected double Height;

        internal WoodenDoor(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double GetWidth()
        {
            return Width;
        }

        public double GetHeight()
        {
            return Height;
        }

        public void PrintDoorParams()
        {
            Console.WriteLine($"door: {GetWidth()} x {GetHeight()} ");
        }
    }
}
