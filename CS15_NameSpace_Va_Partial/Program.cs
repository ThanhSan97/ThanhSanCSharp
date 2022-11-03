using myNS;
using abc = myNS.ABC;
using static System.Math;
namespace CS15
{
    class Program
    {
        static void Main(string[] args)
        {
            myNS.Class1.xinChao();
            abc.Class1.xinChao();
            myNS.ABC.Class1.xinChao();
            System.Console.WriteLine(PI);
            System.Console.WriteLine(Sin(PI/2));
        }
    }
}