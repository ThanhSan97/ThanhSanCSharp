using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
                int x;
                x = 10;
                int z = 2 * x++;
                System.Console.WriteLine(x);
                System.Console.WriteLine(z);
                x = 10;
                int T = 2 * ++x;
                System.Console.WriteLine(x);
                System.Console.WriteLine(T);
                System.Console.WriteLine("================");
                int a = 5, b=6;
                System.Console.WriteLine($"a == b  => {a == b}");
                System.Console.WriteLine($"a != b  => {a != b}");
                System.Console.WriteLine($"a > b  => {a > b}");
                System.Console.WriteLine($"a < b  => {a < b}");
                System.Console.WriteLine($"a >= b  => {a >= b}");
                System.Console.WriteLine($"a <= b  => {a <= b}");
        }
    }
}