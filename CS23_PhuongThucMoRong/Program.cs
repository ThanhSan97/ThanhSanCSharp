namespace CS23_Extension_method
{   

    static class Ex_method
    {

        //phai la phuong thuc tinh
        public static void Show(this string s, ConsoleColor color) //Muon mo rong cho lop nao thi tham so dau tien la lop do =>String
        {
            Console.ForegroundColor = color;
            System.Console.WriteLine(s);
            Console.ResetColor();
        }
        
        public static double BinhPhuong(this double a)
        {
            return a*a;
        }
    }
    class Program
    {   
        static void Main(string[] args)
        {
            string s = "Xin chao cac ban";
            //De s co the su dung phuong thuc show()
            //Viet code trong phuong thuc tinh static
            s.Show(ConsoleColor.Blue);
            // "Xin".Show(ConsoleColor.Red);
            // "Chao".Show(ConsoleColor.Green);
            // "Cac".Show(ConsoleColor.Yellow);
            // "Ban".Show(ConsoleColor.Cyan);
            double a = 3.14;
            System.Console.WriteLine($"Binh phuong cua {a} la : {a.BinhPhuong()}");
        }
    }
}