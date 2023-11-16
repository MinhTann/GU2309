namespace MinhTan
{
    class BT17
    {
        static void Main(string[] args)
        {
            Dog chiahuahua = new Dog("Chahuahua", "Trang");
            Console.WriteLine(chiahuahua.ToString());
        }
    }
}




public class Dog
{
    private String loai, mau;

    public Dog(string loai, string mau)
    {
        this.loai = loai;
        this.mau = mau;
    }

    public string Loai { get => loai; set => loai = value; }
    public string Mau { get => mau; set => mau = value; }
    public override string ToString()
    {
        return string.Format("Loai : {0}, mau : {1}", loai, mau);
    }
}