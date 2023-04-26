using System;


    class Geometry
    {
        protected int width;
        protected int height;

        public Geometry(int w, int h)
        {
            this.width = w;
            this.height = h;
        }

        public virtual int area()
        {
            return 0;
        }
    }

    class Triangle : Geometry
    {
        public Triangle(int w, int h) : base(w, h)
        {
        }

        public override int area()
        {
            return (width * height) / 2;
        }
    }

    class Rectangle : Geometry
    {
        public Rectangle(int w, int h) : base(w, h)
        {
        }

        public override int area()
        {
            return width * height;
        }
    }

    class Assignment2
    {
        //static void Main(string[] args)
        //{
        //    int width = 10;
        //    int height = 5;

        //    Triangle triangle = new Triangle(width, height);
        //    Rectangle rectangle = new Rectangle(width, height);

        //    Console.WriteLine("Triangle Area: " + triangle.area());
        //    Console.WriteLine("Rectangle Area: " + rectangle.area());
        //}
    }

