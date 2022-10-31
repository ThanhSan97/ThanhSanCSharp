namespace CS10_Class
{
    class vuKhi
    {
    
        public string name = "Ten vu khi";
        private int doST = 0;
    //Constructor
        public vuKhi(string name, int doST)
        {
            this.name = name;
            this.doST = doST;
        }
    //Phuong Thuc
        public void thietLapDoSatThuong(int doSatThuong)
        {
            this.doST = doSatThuong;
        }        
        public void TanCong()
        {
            System.Console.WriteLine(name);
            System.Console.Write("Do sat thuong : ");
            for (int i = 0; i < doST; i++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine("\n");
        }
        //Thuoc tinh
        public int satThuong
        {   //Thi hanh khi gan
            set
            {
                doST = value;
            }
            //Thi hanh khi truy cap
            get
            {
                return doST;
            }
        }
        ~vuKhi(){
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Huy");
            Console.ResetColor();
        }
    }
}