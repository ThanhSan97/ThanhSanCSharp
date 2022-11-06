namespace CS20_Delegate
{//Kieu du lieu : Tao ra cac bien tham chieu den cac phuong thuc

    //Khai bao
    public delegate void ShowLog(string message);
    class Program
    {
        static void Info(string s)
        {   Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(s);
            Console.ResetColor();
        }
        static void Warning(string s)
        {   Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine(s);
            Console.ResetColor();
        }

        static int Tong(int a, int b) => a + b;
        static int Hieu(int a, int b) => a - b;

        static void tinhTong(int a, int b, ShowLog log)
        {
            int kq = a + b;
            log?.Invoke($"KQ : {kq}");    
        }
        static void Main(string[] args)
        {
            ShowLog log = null;
            // log = Info;
            // if (log != null)
            //     log("Xin chao");
            // log?.Invoke("Xin chao");

            // log = Warning;
            // log.Invoke("Canh bao !!!");
            log += Info;
            log += Warning;
            log?.Invoke("Xin Chao");

            //Action - Function(Phai co kieu tra ve)
            Action act; // delegare void Func();
            Action<string, int> action1; // delegate void Func(string s, int a);

            Action<string> act2;
            act2 = Warning;
            act2 += Info;
            act2?.Invoke("Xin chao");

            Func<int> f1;
            Func<string, double, string> f2; // Kieu tra ve duoc ghi cuoi cung string
            Func<int, int, int> f3;
            f3 = Tong;
            f3 += Hieu;
            // f3?.Invoke(2,3);
            System.Console.WriteLine(f3(2,3));

            tinhTong(3,5,Info);
        }
    }
}