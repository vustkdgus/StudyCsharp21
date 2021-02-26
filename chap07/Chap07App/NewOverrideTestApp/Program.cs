using System;

namespace NewOverrideTestApp
{
    class Mammal //포유류
    {
        public string Name { get; set; }

        public void Breathe()
        {
            Console.WriteLine($"{this.Name}이(가) 숨을 쉰다");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{this.Name}이(가) 이동한다");
        }
    }

    class Dog : Mammal
    {
        public override void Move()
        {
            base.Move();
            Console.WriteLine($"{this.Name}이(가) 네발로 달린다.");
        }
    }

    class Human : Mammal
    {
        public override void Move()
        {
            base.Move();
            Console.WriteLine($"{this.Name}이(가) 두발로 달린다.");
        }
    }

    class Whale : Mammal
    {
        public override void Move()
        {
            base.Move();
            Console.WriteLine($"{this.Name}이(가) 헤엄쳐서 달린다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog ppoppi = new Dog();
            ppoppi.Name = "뽀삐";
            ppoppi.Move();

            Human mansigi = new Human();
            mansigi.Name = "만식이";
            mansigi.Move();

            Whale whale = new Whale();
            whale.Name = "고래";
            whale.Move();

        }
    }
}
