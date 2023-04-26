

using System.Xml.Linq;

class Program
{
    static int MyMethod(int x)
    {
        return 5 + x;
    }

    static void MyMethod(string fname)
    {
        Console.WriteLine(fname + " Refsnes");
    }

    static void Main(string[] args)
    {
        Console.WriteLine(MyMethod(3));
        MyMethod("Liam");
        MyMethod("Jenny");
        MyMethod("Anja");
    }

}