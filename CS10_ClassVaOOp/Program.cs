namespace CS10_Class
{
    class program
    {
        static void Main(string[] args)
        {
            vuKhi sungluc = new vuKhi("Sung Luc", -1);
            vuKhi sungTruong = new vuKhi("Sung Truong", 5);
            vuKhi sungMay = new vuKhi("Sung May", 10);
            sungluc.TanCong();
            sungTruong.TanCong();
            sungMay.TanCong();
            sungluc.satThuong = -1;
            System.Console.WriteLine(sungluc.satThuong);
            
        }   
    }
}