using System;
using a0_SimpleFactory.Door.Interfaces;

namespace a0_SimpleFactory.Door.Models
{
    internal class WoodenDoor : IDoor
    {
        private readonly double _width;
        private readonly double _height;

        public WoodenDoor(double width, double height)
        {
            Console.WriteLine("Wooden door has been made");
            _width = width;
            _height = height;
        }

        public double GetWidth()
        {
            return _width;
        }

        public double GetHeight()
        {
            return _height;
        }

        public void PrintDimensions()
        {
            Console.WriteLine($"Door dimensions: {GetWidth()} x {GetHeight()}");
        }
    }
}
