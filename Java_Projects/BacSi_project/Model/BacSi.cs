namespace BacSi_Project
{
    public class BacSi : IBacSi
    {
        protected String mabs { set; get; }
        protected String hoTen { set; get; }
        protected double mucLuong { set; get; }

        public BacSi() { }

        public BacSi(String mabs, String hoTen, double mucLuong)
        {
            this.mabs = mabs;
            this.hoTen = hoTen;
            this.mucLuong = mucLuong;
        }

        public double luonghangthang()
        {
            throw new NotImplementedException();
        }

        public BacSi themBacSi()
        {
            return null;
        }
        public override string ToString()
        {
            return $"{mabs} : {hoTen} : {mucLuong}";
        }
    }

    public class BsBanTG : BacSi
    {
        private double luongNgay { set; get; }
        private int soNgayLamViec { set; get; }

        public BsBanTG(double luongNgay, int soNgayLamViec)
        {
            this.luongNgay = luongNgay;
            this.soNgayLamViec = soNgayLamViec;
        }

        public BsBanTG(double luongNgay, int soNgayLamViec, string mabs, string hoTen, double mucLuong)
        {
            this.mabs = mabs;
            this.hoTen = hoTen;
            this.mucLuong = mucLuong;
            this.luongNgay = luongNgay;
            this.soNgayLamViec = soNgayLamViec;
        }

        public BacSi themBacSi()
        {
            System.Console.WriteLine("Nhap ma bac si: ");
            string ma = Console.ReadLine();
            System.Console.WriteLine("Nhap ho ten bac si: ");
            string ht = Console.ReadLine();
            System.Console.WriteLine("Nhap muc luong: ");
            double luong = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Nhap luong ngay: ");
            double luongN = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Nhap so ngay lam viec: ");
            int songay = int.Parse(Console.ReadLine());
            BacSi bs = new BsBanTG(luongN, songay, ma, ht, luong);
            return bs;
        }
    }
    public class BsToanTG : BacSi
    {
        private double luongKham { set; get; }
        private double luongXetNghiem { set; get; }

        public BsToanTG() { }

        public BsToanTG(double luongKham, double luongXetNghiem)
        {
            this.luongKham = luongKham;
            this.luongXetNghiem = luongXetNghiem;
        }

        public BsToanTG(double luongKham, double luongXetNghiem, string mabs, string hoTen, double mucLuong)
        {
            this.mabs = mabs;
            this.hoTen = hoTen;
            this.mucLuong = mucLuong;
            this.luongKham = luongKham;
            this.luongXetNghiem = luongXetNghiem;
        }
        double luonghangthang => luongKham + luongXetNghiem + mucLuong;

        public BacSi themBacSi()
        {
            System.Console.WriteLine("Nhap ma bac si: ");
            string ma = Console.ReadLine();
            System.Console.WriteLine("Nhap ho ten bac si: ");
            string ht = Console.ReadLine();
            System.Console.WriteLine("Nhap muc luong: ");
            double luong = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Nhap luong kham: ");
            double luongK = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Nhap luong xet nghiem: ");
            double luongX = double.Parse(Console.ReadLine());
            BacSi bs = new BsToanTG(luongK, luongX, ma, ht, luong);
            return bs;
        }
    }
}