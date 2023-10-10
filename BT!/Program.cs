using System;
namespace MinhTan
{
    class Baitap1
    {
        static void Main(string[] args)
        {
            float Toan, Ly, Hoa, diemtrungbinh;
            
            Console.WriteLine("Nhap diem theo thu tu Toan, Ly, Hoa: ");
            Hoa = float.Parse(Console.ReadLine());
            Toan = float.Parse(Console.ReadLine());
            Ly = float.Parse(Console.ReadLine());
            if(Hoa < 10 & Toan < 10  & Ly < 10)
            {
                diemtrungbinh = (Hoa + Ly + Hoa) / 3;
                Console.WriteLine("Diem Hoa: " + Hoa + "\nDiem Toan: " + Toan + "\nDiem Ly: " + Ly);
                Console.WriteLine("Diem Trung Binh : {0}", diemtrungbinh);
            } else
            {
                Console.WriteLine("So diem ban nhap khong hop le");
            }
            
              

            
                
        }
    }
}