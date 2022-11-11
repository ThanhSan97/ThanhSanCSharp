namespace CS24
{
    class countNumber
    {       
        public static int number = 0;

        public static void Info()
        {
            System.Console.WriteLine($"So lan truy cap : {number}");
        }

        public void Count()
        {
            number++;
        }
    }
    class Student
    {
        public readonly string name ; // chi doc

        public Student(string _name)
        {
            name = _name;
        }
    }
    
    class Vector
    {
        double x, y;

        public Vector(double _x, double _y)
        {
            x = _x;
            y = _y;
        }

        public void Info()
        {
            System.Console.WriteLine($"x = {x}, y = {y}");
        }

        // qua tai toan tu
        // toan tu + 2 vector
        public static Vector operator+(Vector v1, Vector v2) // operator[toan tu]
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y);
        }
         //Indexer
         public double this[int i] //this[kieu DL]
         {
            set{ //Thiet lap gia tri
                switch (i)
                {
                    case 0:
                        x = value;
                        break;
                    case 1:
                        y = value;
                        break;
                    default:
                        throw new Exception("Chi so sai");
                }
            }

            get { // Doc
                switch (i)
                {
                    case 0:
                        return x;
                    case 1:
                        return y;
                    default:
                        throw new Exception("Chi so sai");
                }
            }
         }
    }
    class Program
    {

        //phuong thuc tinh - static
        static void Main(string[] args)
        {
            countNumber c1 = new countNumber();
            countNumber c2 = new countNumber();
            countNumber c3 = new countNumber();

            c1.Count();
            c2.Count();

            countNumber.Info();

            Student s = new Student("Nguyen Van A");
            System.Console.WriteLine(s.name);


            Vector v1 = new Vector(2,3);
            Vector v2 = new Vector(1,1);

            v1.Info();
            v2.Info();

            var v3 = v1 + v2;
            v3.Info();
            v1[0] = 5;
            v1[1] = 6;
            v1.Info();
        }
    }
}