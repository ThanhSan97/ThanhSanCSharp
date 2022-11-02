namespace CS14_TinhKeThua
{   class Animal
    {
        public int Legs{set; get;}
        public float Weight{set; get;}
        public void ShowLegs(){
            System.Console.WriteLine(Legs);
        }
    }

    class Cat : Animal
    {
        public string Sound;
        public Cat()
        {
            this.Legs = 4;
            this.Sound = "Meow Meow";
        }
        public void ShowSound()
        {
            System.Console.WriteLine(Sound);
        }

        public new void ShowLegs()
        {
            System.Console.WriteLine($"Loai meo co {Legs} chan");
        }
        public void ShowInfor()
        {
            
        }
    }
    class Program
    {
        //Tinh ke thua - B:A

        static void Main(string[] args)
        {
            Cat c = new Cat();
            c.ShowSound();
            c.ShowLegs();
        }
    }
}
