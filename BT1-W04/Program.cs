int[] array = new int[10];
array[0] = 10;
array[1] = 4;
array[2] = 6;
array[3] = 7;
array[4] = 8;
int x;
Console.WriteLine("Nhap so can chen");
x = int.Parse(Console.ReadLine());
int index;
Console.WriteLine("Nhap vi tri can chen vao: ");
index = int.Parse(Console.ReadLine());
if(index <= 1 || index > array.Length)
{
    Console.WriteLine("Khong the them vao vi tri nay");
} else
{
    array[index - 1] = x;
    
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write("\n" + array[i] + " ");
}
