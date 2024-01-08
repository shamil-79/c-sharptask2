using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public interface Shape
    {
        double Getarea();
        
    }
   
    public class Circle: Shape
    {
        double Radious { get; set; }
        public Circle(int radious)
        {
            Radious = radious;
        }
        public double Getarea()
        {
            return Math.PI * Radious * Radious;
        }
    }
    public class Rectangle: Shape
    {
        int Height { get; set;}
        int Width { get; set;}
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public double Getarea() 
        { 
            return Height * Width; 
        }

    }
    public class Square : Shape
    {
        int Meter;
        public Square(int meter)
        {
            Meter = meter;
        }
        public double Getarea()
        {
            return Meter * Meter;
        }

    }
    public class Areafinder
    {
        public static void Main(string[] args)
        {
            Circle circle= new Circle(4);
            Console.WriteLine(circle.Getarea());
            Rectangle rectangle = new Rectangle(6, 3);
            Console.WriteLine(rectangle.Getarea());
            Square square = new Square(4);
            Console.WriteLine(square.Getarea());


        }
    }
}
