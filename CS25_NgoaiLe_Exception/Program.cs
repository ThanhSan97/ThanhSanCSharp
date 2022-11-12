using System;
using MyExceptions;
namespace CS25_Exception
{
    //Exception - Phat sinh khi bi loi

    
    class Program
    {
        static void Reigister(string name, int age)
        {   
            if (string.IsNullOrEmpty(name))
            {
                throw new NameEmptyException();
            }
            if (age < 18 || age > 100)
            {
                throw new AgeException(age);
            }
            System.Console.WriteLine($"Xin chao {name} {age} tuoi");
        }
        static void Main(string[] args)
        {
            int a = 5;
            int b =0;

            try
            {
                var c = a/b;  
                System.Console.WriteLine(c);
                int[] i = {2,3};
                var x = i[4];
                // System.Console.WriteLine(x);
            }
            catch (DivideByZeroException e)
            {
                System.Console.WriteLine(e.Message);
                System.Console.WriteLine("Phep chia co loi");
            }
            catch (IndexOutOfRangeException e1)
            {
                System.Console.WriteLine(e1.Message);
                System.Console.WriteLine("Chi so mang khong hop le");
            }
            catch(Exception e2)
            {
                System.Console.WriteLine(e2.Message);
            }


            string path = null;
            try
            {
                string s = File.ReadAllText(path);
                System.Console.WriteLine(s);
            }
            catch(FileNotFoundException fnfe){
                System.Console.WriteLine(fnfe.Message);
                System.Console.WriteLine("Khong tim thay file");
            }
            catch(ArgumentNullException agne)
            {
                System.Console.WriteLine(agne.Message);
                System.Console.WriteLine("Duong dan loi");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
// -----------------------------------------
            try
            {
                Reigister("s",16);
            }
            catch(NameEmptyException nee)
            {
                System.Console.WriteLine(nee.Message);
            }
            catch(AgeException ae){
                System.Console.WriteLine(ae.Message);
                ae.Detail();
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine(e.Message);
                // System.Console.WriteLine("Ten khong duoc de trong");
            }
        }       
    }
}