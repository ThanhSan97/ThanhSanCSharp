namespace sanPham
{
    public partial class Product
    {
        public class Manufactory
        {
            public string name {set; get;}
            public string address {set; get;}

        }
        public string name {set; get;}
        public decimal price {set; get;}

        public string getInfo()
        {
            return $"{name}, {price}, {discription}";
        }
    }
}