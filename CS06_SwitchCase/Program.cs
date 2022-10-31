using System;
namespace Buoi6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            char c;
            Console.WriteLine("Nhap so a : "); 
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so b : "); 
            b = Convert.ToInt32(Console.ReadLine());
            L1:
            Console.WriteLine("Nhap yeu cau cua ban : ");
            Console.WriteLine("1. Tinh tong");    
            Console.WriteLine("2. Tinh hieu");    
            Console.WriteLine("3. Tinh tich");    
            Console.WriteLine("4. Tinh thuong");    
            c = Console.ReadKey().KeyChar;
            Console.WriteLine("\n");
            switch (c)
            {
                case '1':
                    System.Console.WriteLine($"a + b = {a + b}");
                    // goto L1;
                break;
                case '2':
                    System.Console.WriteLine($"a - b = {a - b}");
                break;
                case '3':
                    System.Console.WriteLine($"a * b =  {a * 2}");
                break;
                case '4':
                    System.Console.WriteLine($"a / b =  {a / 2}");
                break;
                default:
                    System.Console.WriteLine("Nhap khong hop le !");
                break;
            }
        }
    }
}