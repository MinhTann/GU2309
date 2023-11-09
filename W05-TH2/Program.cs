namespace MinhTann
{
    class W05
    {
        static void Main(string[] args)
        {
            Random rd  = new Random();
            int n;
            Console.WriteLine("Nhap so mang ban muon: ");
            n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rd.Next(1,20);
                Console.Write(array[i] + " ");
            }

        } 
    }
}