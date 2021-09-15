using System;

namespace RectangleApplication
{
    class Circle
    {
        internal double radius;
        double r;

        double GetArea()
        {
            return radius * radius * 3.14;
        }

        public void Display()
        {
            Console.WriteLine("Radius: {0}", radius);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
    class Rectangle
    {
        private double length;
        private double width;

        public void AcceptDetails()
        {
            length = 4.5;
            //Console.WriteLine("請輸入長度：");
            //length = Convert.ToDouble(Console.ReadLine());
            
            width = 3.5;
            // Console.WriteLine("請輸入寬度：");
            // width = Convert.ToDouble(Console.ReadLine());
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.AcceptDetails();
            r.Display();

            Circle c = new Circle();
            c.radius = 4;
            c.r = 5;
            Console.WriteLine(c.radius);
            // c.Display();
            //Console.ReadLine();
        }
    }
}