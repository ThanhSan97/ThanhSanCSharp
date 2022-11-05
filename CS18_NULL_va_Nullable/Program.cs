namespace CS18
{
    class Program
    {   
        class SinhVien
        {
            public void xinChao(){
                System.Console.WriteLine("Xin chao");
            }
            
        }
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();
            // if(sv != null){
            //     sv.xinChao();
            // }
            sv?.xinChao();
            //nullable
            int? age;
            age = null;
            // age = 10;
            if (age.HasValue)
            {
                int _age = age.Value;
                System.Console.WriteLine(_age);   
            } else 
            {
                System.Console.WriteLine("No value");
            }
        }
    }
}