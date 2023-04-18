using System;

public class Math
{
    public int number1 { get; set; }
    public int number2 { get; set; }

    public Math(int num1, int num2)
    {
        this.number1 = num1;
        this.number2 = num2;
    }

    public virtual int calculate()     
    {
        return 0;
    }
}

public class Addition : Math
{
    public Addition(int num1, int num2) : base(num1, num2) { }

    public override int calculate()
    {
        return number1 + number2;
    }
}

public class Subtraction : Math
{
    public Subtraction(int num1, int num2) : base(num1, num2) { }

    public override int calculate()
    {
        return number1 - number2;
    }
}

public class Multiplication : Math
{
    public Multiplication(int num1, int num2) : base(num1, num2) { }

    public override int calculate()
    {
        return number1 * number2;
    }
}

public class Division : Math
{
    public Division(int num1, int num2) : base(num1, num2) { }

    public override int calculate()
    {
        if (number2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero");
        }
        return number1 / number2;
    }
}

public class Assignment1
{
    //public static void Main(string[] args)
    //{
    //    int num1 = 100;
    //    int num2 = 50;

    //    Addition add = new Addition(num1, num2);
    //    Subtraction sub = new Subtraction(num1, num2);
    //    Multiplication mul = new Multiplication(num1, num2);
    //    Division div = new Division(num1, num2);

    //    Console.WriteLine("Addition: " + add.calculate());
    //    Console.WriteLine("Subtraction: " + sub.calculate());
    //    Console.WriteLine("Multiplication: " + mul.calculate());
    //    Console.WriteLine("Division: " + div.calculate());
    //}
}
