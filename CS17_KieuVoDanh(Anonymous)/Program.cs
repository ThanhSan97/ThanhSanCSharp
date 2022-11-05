namespace CS17_Anonymous
{
    class Program
    {   //new {thuoctinh = giatri, thuoctinh2 = giatri2}
        // dynamic - kieu du lieu dong
        class SinhVien
        {
            public string Hoten {set; get;}
            public int NamSinh {set; get;}
            public string NoiSinh {set; get;}

            public void Hello()
            {
                System.Console.WriteLine($"Xin chao {this.Hoten}");
            }
        }
        static void PrintInfo(dynamic obj)
        {
            obj.Hoten = "Nam";
            obj.Hello();
        }
        static void Main(string[] args)
        {
            // var sanpham = new 
            // {
            //     Ten = "Iphone",
            //     Gia = 1000,
            //     Namsx = 2022
            // };
            // System.Console.WriteLine(sanpham.Ten);
            // System.Console.WriteLine(sanpham.Gia);
            List<SinhVien> dsSinhVien = new List<SinhVien>()
            {
                new SinhVien(){ Hoten = "Nam", NamSinh = 2000, NoiSinh = "Ha Noi" },
                new SinhVien(){ Hoten = "Tuan", NamSinh = 2002, NoiSinh = "TPHCM" },
                new SinhVien(){ Hoten = "Minh", NamSinh = 2001, NoiSinh = "Ha Noi" },
                new SinhVien(){ Hoten = "Hoang", NamSinh = 2003, NoiSinh = "Da Nang" }
            };
            var kq = from sv in dsSinhVien
                    where sv.NoiSinh == "Ha Noi"
                    select new {
                        Ten = sv.Hoten,
                        Noisinh = sv.NoiSinh
                    };
            foreach (var sinhvien in kq)
            {
                System.Console.WriteLine(sinhvien.Ten + " - " + sinhvien.Noisinh);
            }
            // int a = 1;
            // PrintInfo(a);
            SinhVien sv1 = new SinhVien();
            PrintInfo(sv1);
        }
    }
}