Console.WriteLine("Nhap so cot:");
int cot = int.Parse(Console.ReadLine());
Console.WriteLine("Nhap so dong");
int dong = int.Parse(Console.ReadLine());
List<List<int>> list = new List<List<int>>();

for(int i1 = 0; i1 < cot; i1++)
{
    List<int> row = new List<int>();
    for(int j1 = 0; j1 < dong; j1++)
    {
        Console.WriteLine("Nhap gia tri cho cot {0}, dong{1}: ", i1, j1);
        int value = int.Parse(Console.ReadLine());
        row.Add(value);
    }
    list.Add(row);
}
int max = list[0][0];
int i = 0;
int j = 0;

for( i = 0; i < list.Count;i++)
{
    for( j= 0; j < list.Count; j++)
    {
        if (list[i][j] > max)
        {
            max = list[i][j];
        }
    }
}
Console.WriteLine("So lon nhat la {0} tai cot {1}, dong {2}", max, i, j);
