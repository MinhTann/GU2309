namespace buoi21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;

            Console.WriteLine("Duong dan cua file exe la: " + exeDirectory);
            try
            {
                string sourcePath = exeDirectory + "Data.txt"; // Đường dẫn của tệp nguồn
                string destinationPath = @"D:\HocTap"; // Đường dẫn của thư mục đích

                // Kiểm tra xem tệp nguồn tồn tại không
                if (File.Exists(sourcePath))
                {
                    // Đảm bảo thư mục đích tồn tại
                    Directory.CreateDirectory(destinationPath);

                    // Tạo đường dẫn đến tệp đích
                    string destinationFile = Path.Combine(destinationPath, Path.GetFileName(sourcePath));

                    // Sao chép tệp từ nguồn đến đích
                    File.Copy(sourcePath, destinationFile, true);

                    Console.WriteLine("Sao chep thanh cong.");
                }
                else
                {
                    Console.WriteLine("Tep nguon khong ton tai.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }
    }
    
}