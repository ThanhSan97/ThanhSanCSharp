namespace CS05
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            System.Console.WriteLine("Nhap a : ");
            a = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Nhap b : ");
            b = float.Parse(Console.ReadLine());

            float max;
            if( a > b){
                max = a;
            } else {
                max = b;
            }
        System.Console.WriteLine($"So lon nhat la : {max}");
        }   
    }
}