using System.Linq;

List<int> a = new List<int>();
int n = 10;
Random rd = new Random();
for (int i = 0; i < n; i++)
{
    a.Add(rd.Next(1, 50));
}
Console.WriteLine(String.Join(" ", a));

foreach (int item in a)
{
    if (item % 2 == 0)
    {
        Console.Write(item + " ");
    }
    
    
}
Console.WriteLine(String.Join(" ", a.Where(item => item % 2 == 0)));

Console.WriteLine(String.Join(" ", a.Where(item => isChinhPhuong(item))));
Console.WriteLine(String.Join(" ", a.Where(item => isSole(item)

static bool isChinhPhuong(int n)
{
    int i = (int)Math.Sqrt(n);
    return i * i == n;
}
static bool isSole(int n)
{
    if(n % 2 != 0)
    {
        return n * 2 = n;
       
    }
    return false;
}

