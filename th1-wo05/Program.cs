namespace minhtann
{
    class wo5
    {
        public static List<int> MinValua2(List<int> array)
        {
            List<int> list = new List<int>() { 0 };
            int min = array[0];
            int index = 0;
            for (int i = 1;i < array.Count; i++)
            {
                if (array[i]< min)
                {
                    min = array[i];
                    index = i;  
                    list.Clear();
                    list.Add(i);
                } 
                else if (array[i]== min)
                {
                    list.Add(i);
                }
                
            }
            return list;
        }
        public static void Main(string[] args)
        {
            List<int> arr = new List<int>(){ 4, 12, 7, 8, 9, 2, 1, 3, 4, };
            List<int> index2 = MinValua2(arr);
            Console.WriteLine(String.Join(",", index2));
            
        }
    }
}