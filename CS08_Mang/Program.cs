using System.Linq;
namespace Mang
{
    class Program
    {
        static void Main(string[] args)
        {   //Khai bao mang
            string[] ds = new string[3] ;
            ds[0] = "Thanh San";
            ds[1] = "Van Nam";

            int[] mangsonguyen = {1,5,7,4,3,2,9,6}; 
            double[] mangsothuc = new double[3] {0.5, 0.7, 1.2};
             // Duyet mang
             // for
            //  for(int i = 0; i < mangsonguyen.Length; i++)
            //  {
            //     System.Console.WriteLine(mangsonguyen[i]);
            //  }
            // foreach
            //  foreach(int item in mangsonguyen)
            //  {
            //     System.Console.WriteLine(item);
            //  }
             // Phuong thuc
            //  System.Console.WriteLine($"So phan tu : {mangsonguyen.Length}");
            //     //So chieu
            //  System.Console.WriteLine($"So chieu : {mangsonguyen.Rank}"); 
            //     //GTNN / GTLN
            // System.Console.WriteLine($"GTNN : {mangsonguyen.Min()}");
            // System.Console.WriteLine($"GTLN : {mangsonguyen.Max()}");
            //     //Tinh tong
            // System.Console.WriteLine($"Tong cac phan tu: {mangsonguyen.Sum()}");
            //     //Sap xep
            // Array.Sort(mangsonguyen);
            // foreach(int item in mangsonguyen)
            //  {
            //     System.Console.WriteLine(item);
            //  } 
            // Mang 2 chieu
            double[,] mang2chieu = {{2,3,4.5}, {1,9,8}};
            // foreach(var phantu in mang2chieu)
            // {
            //     System.Console.Write($"{phantu} \t");
            //     // System.Console.WriteLine("\n");
            // }           
            System.Console.WriteLine(mang2chieu.Rank);
        }
    }
}