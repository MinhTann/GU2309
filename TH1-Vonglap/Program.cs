Console.WriteLine("Linear Equation Resolver");
Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants:");
Console.Write("a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("b: ");
double b = Convert.ToDouble(Console.ReadLine());
if( a!= 0)
{
    double x = -b / a;
    Console.Write("The Soliution is:" + x);
}
else
{
    if(b == 0)
    {
        Console.Write("Solution is all x");

    } else
    {
        Console.Write("Vo nghiem");
    }
}