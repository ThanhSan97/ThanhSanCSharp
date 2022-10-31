using System.Text;

namespace CS11_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string thongbao = "       Xin chao cac ban !!!       ";
            System.Console.WriteLine(thongbao);
            int dodai = thongbao.Length;
            /*Cat bo ki tu dau/cuoi
            Trim()
            TrimStart();
            TrimEnd();
            */
            thongbao = thongbao.Trim();
            //IN HOA, IN THUONG
            thongbao = thongbao.ToUpper();
            // thongbao.ToLower();
            //REPLACE
            thongbao = thongbao.Replace("XIN CHAO","Chao mung"); // Thay chuoi "Xin Chao" thanh chuoi "Chao mung"
            //INSERT - Insert(<Chi so>, <Gia tri chen>)
            thongbao = thongbao.Insert(10,"tat ca ");
            // for (int i = 0; i < thongbao.Length; i++)
            // {
            //     System.Console.Write($"{thongbao[i]} ");
            // }
            //Lay ra chuoi con SUBSTRING
            string chuoicon = thongbao.Substring(10,3);
            //Xoa chuoi con
            thongbao = thongbao.Remove(10,7);
            //Chia chuoi thanh cac mang chuoi con SPLIT
            string[] mangChuoiCon = thongbao.Split(' ');
            foreach (var chuoi in mangChuoiCon)
            {
                System.Console.WriteLine(chuoi);
            }
            //Noi Chuoi JOIN(<ki tu giua cac chuoi>, <Mang chuoi con>)
            string[] cacChuoiCon = {
                "Hom",
                "Nay",
                "La",
                "Thu",
                "2"
            };
            string chuoi1 = string.Join(' ',cacChuoiCon);
            System.Console.WriteLine(chuoicon);
            System.Console.WriteLine(chuoi1);
            System.Console.WriteLine(thongbao);

            //StringBuilder
            StringBuilder sb = new StringBuilder(10);
            sb.Append("Xin chao");
            sb.Append("cac ban");
            sb.Replace("Xin chao","Chao mung");
            string kq = sb.ToString();
            System.Console.WriteLine(kq);
        }
    }
}