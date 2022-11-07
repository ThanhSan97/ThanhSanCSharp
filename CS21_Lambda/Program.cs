namespace CS21_Lambda
{
    class Program
    {   //Lambda - Anonymous Function
        /* Khai báo
            1. (int a, int b) => a+b;
            2. (tham so) => 
            {
                cac bieu thuc;
                return ...;
            }
        */
        static void Main(string[] args)
        {   //Khai bao
            Action<string> thongbao; //Khong co tham so tra ve
            thongbao = (string s) => System.Console.WriteLine(s);
            Action<string, string> loichao;
            loichao = (s,n) => 
            { 
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine($"{s} {n}"); //Khong can khai bao kieu DL
                Console.ResetColor();
            };
            // (int a, int b) => 
            // {
            //     int kq = a * b;
            //     return kq;
            // };
            thongbao?.Invoke("Xinchao");
            loichao?.Invoke("Xin chao","San");
            //Co kieu tra ve
            Func<int, int, int> tinhtoan;
            tinhtoan = (a, b) =>
            {
                int kq = a + b;
                return kq;
            };
            System.Console.WriteLine($"Ket qua : {tinhtoan(5,6)}");
            //Vi du
            int[] mangsonguyen = {1,4,9,16,25,36,49};
            var kq = mangsonguyen.Select((int a) => {
                return Math.Sqrt(a);
            });
            foreach (var item in kq)
            {
                System.Console.WriteLine(item);
            }
            mangsonguyen.ToList().ForEach(
                (x) =>{
                    if(x % 2 != 0){
                        System.Console.WriteLine(x);
                    }
                }
            );
        }
    }
}