class Program
{
    static string CalculateGrade(int marks)
    {
        return marks >= 60 ? "First Division" :
               marks >= 45 ? "Second Division" :
               marks >= 33 ? "Third Division" : "Fail";
    }
    static void findX(double a, double b)
    {
        if (a == 0)
        {
            throw new ArgumentException("A must not be zero.");
        }

        double x = -b / a;
        Console.WriteLine(x);
    }

    static void FindX1X2(double a, double b, double c)
    {
        double delta = b * b - 4 * a * c;
        if (delta >= 0)
        {
            double sqrtDelta = Math.Sqrt(delta);
            double x1 = (-b + sqrtDelta) / (2 * a);
            double x2 = (-b - sqrtDelta) / (2 * a);
            Console.WriteLine($"x1 = {x1}, x2 = {x2}");
        }
        else
        {
            Console.WriteLine("Equation no experience");
        }
    }
    static void Main(string[] args)
    {
        //Console.WriteLine(CalculateGrade(60));

        //findX(1, 2);

        FindX1X2(1, 2,-1);
    }
}
