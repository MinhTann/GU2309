Console.WriteLine("Nhap chieu dai cua hinh vuong");
int n = int.Parse(Console.ReadLine());
Random rd = new Random();
int[,] array = new int[n, n];
for (int i = 0; i < n; i++)
{
    for(int j = 0; j < n; j++)
    {
        array[i, j] = rd.Next(10, 50);

    }
   
   
}
Console.WriteLine("Cac phan tu ngau nhien: ");
int total = 0;
for (int i = 0;i < n; i++)
{
    for(int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
        if (i == j) total += array[i, j];
    }
    Console.WriteLine("");
}
Console.WriteLine("Tong duong cheo cua hinh vuong la {0}", total);