namespace CS13_Math
{
    class Program
    {
        static void Main(string[] args)
        {   //Hang so
                System.Console.WriteLine(Math.PI);
                System.Console.WriteLine(Math.E);
            //MAX/MIN
                System.Console.WriteLine(Math.Max(5,6));
                System.Console.WriteLine(Math.Min(Math.Min(5,6),4));
            //Gia tri tuyet doi Abs
            //Xac dinh dau : Sign 
                System.Console.WriteLine(Math.Abs(-97));
            //Ham luong giac => Radian
                System.Console.WriteLine($"Sin : {Math.Sin(Math.PI/2)}");
            //Can, Luy thua
                System.Console.WriteLine(Math.Sqrt(25));
                System.Console.WriteLine($"Luy thua : {Math.Pow(2,3)}");
                System.Console.WriteLine($"Logarit : {Math.Log(Math.E)}");
            // Lam tron 
            //Round
                System.Console.WriteLine($"Lam tron : {Math.Round(4.7)}");
            //Ceiling , Floor
                System.Console.WriteLine($"Lam tron len : {Math.Ceiling(4.3)}");
                System.Console.WriteLine($"Lam tron xuong : {Math.Floor(4.3)}");
            //Truncate - Cat di phan thap phan
                System.Console.WriteLine(Math.Truncate(5.4));
        }
    }
}