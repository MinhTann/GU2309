class Rectangle
{
    double width, height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double Width { get => width; set => width = value; }
    public double Height { get => height; set => height = value; }
    public double getDT() { return width * height; }

    public double getCV() { return 2 * (width + height); }
    public override String ToString()
    {
        return "Rectangle{" + "width=" + width + ", height=" + height + "}";
    }
    static void Main(string[] args)
    {
        Rectangle a = new Rectangle(2, 5);
        Console.WriteLine(a.ToString());
        Console.WriteLine(a.getCV());
        Console.WriteLine(a.getDT());
    }
}
