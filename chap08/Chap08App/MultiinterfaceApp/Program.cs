using System;

namespace MultiinterfaceApp
{
    interface IRunnable // 자동차 종류
    {
        void Run();
    }

    interface IFlyable // 비행기 종류
    {
        void Fly();
    }

    class DroneCar : IRunnable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("날아!");
        }

        public void Run()
        {
            Console.WriteLine("달려!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("드론카");

            DroneCar dreamcar = new DroneCar();
            dreamcar.Run();
            dreamcar.Fly();

            Console.WriteLine("자동차로 변경(interface)");
            IRunnable car = dreamcar;
            car.Run();
            //car.Fly(); 오류

            IFlyable plane = dreamcar;
            plane.Fly();
            //plane.Run(); 오류
        }
    }
}
