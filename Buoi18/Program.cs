public class Shape
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public int Height { get; set; }
    public int Width { get; set; }

    public  void Draw()
    {
        Console.WriteLine("Performing base class drawing");
    }
}
class Circle : Shape
{
    public  void Draw()
    {
        Console.WriteLine("Drawing a circle");
        base.Draw();
    }
}
class Rectangle : Shape
{
    public  void Draw()
    {
        Console.WriteLine("Drawing a Rectangle");
        base.Draw();
    }
}

class Triangle : Shape
{
    public  void Draw()
    {
        Console.WriteLine("Drawing a Triangle");
        base.Draw();
    }
}
class Program
{
    static void Main(string[] args)
    {
        var shapes = new List<Shape>()
        {
            new Rectangle(),
            new Triangle(),
            new Triangle()
        };
        foreach(var shape in shapes)
        {
            shape.Draw();
        }
        Console.WriteLine("Press any key to exit");
    }
}

