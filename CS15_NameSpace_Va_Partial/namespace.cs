namespace myNS
{   //Co the khai bao Class, struct, enum
    // NS con
    public class Class1
    {
        public static void xinChao()
        {
            System.Console.WriteLine("Xin chao tu class 1");
        }
    }
    namespace ABC
    {
        public class Class1
        {
            public static void xinChao()
            {
                System.Console.WriteLine("Xin chao tu class 1 - NS ABC");
            }
        }
    }
}