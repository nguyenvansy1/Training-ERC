
// Open-closed Principle
// Liskov Substitution Principle
// Open-closed Principle
interface IArea
{
    double CalculateArea();
}


class Rectangle : IArea
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double CalculateArea()
    {
        double area = Height * Width;
        return area;
    }
}

class Square : IArea
{
    public double Width { get; set; }
 
    public double CalculateArea()
    {
        double area = Width * Width;
        return area;
    }
}

class Circle : IArea
{
    public double Radius { get; set; }

    public double CalculateArea()
    {
        double area = Radius*Radius*Math.PI;
        return area;
    }
}

class CostManager
{
    public double Calculate(IArea shape)
    {
        double costPerUnit = 1.5;
        double totalCost = costPerUnit * shape.CalculateArea();
        return totalCost;
    }
}

