namespace PhuongThuc
{
    class Program
    {
        static int Tinhtong(int a, int b)
        {
            return a + b;
        }
        public static void xinChao(string ho, string ten)
        {
            string fullName = ho + " " + ten;
            System.Console.WriteLine($"Xin chao {fullName}");
        }
        public static void binhPhuong(ref int a)
        {
            a = a*a;
            System.Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(Tinhtong(2,3));
            xinChao("Nguyen","San");
            int a = 5;
            binhPhuong(ref a);
            System.Console.WriteLine(a);
        }
    }
}