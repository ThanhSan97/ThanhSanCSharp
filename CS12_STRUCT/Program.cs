namespace CS12_STRUCT
{
    class Program
    {   enum NoiSX
        {
            Anh,
            My,
            Duc
        }
        public struct Product
        {
            public string name;
            public double price;
            public string NoiSanXuat;
            public string getInfo()
            {
                return $"Ten san pham : {name}, Gia : {price}, Noi san xuat : {NoiSanXuat}";
            }
            //COnstructor
            public Product(string name, int price, string NoiSanXuat)
            {
                this.name = name;
                this.price = price;
                this.NoiSanXuat = NoiSanXuat;
            }
        }
        static void Main(string[] args)
        {
            Product product1;
            product1.name = "Iphone";
            product1.price = 1000;
            product1.NoiSanXuat = NoiSX.Anh.ToString();
            System.Console.WriteLine(product1.getInfo());
            Product product2 = new Product("SamSung", 900,NoiSX.Duc.ToString());
            System.Console.WriteLine(product2.getInfo());
        }
    }
}