using System;

namespace CS02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            float a,b;
            string s;
            System.Console.WriteLine("Nhap a : ");
            s = Console.ReadLine();
            a = Convert.ToSingle(s);
            System.Console.WriteLine("Nhap b : ");
            s = Console.ReadLine();
            b = float.Parse(s);
            System.Console.WriteLine("a = {0}, b = {1}", a,b);
        }
    }
}