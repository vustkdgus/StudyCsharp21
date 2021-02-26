using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestApp
{
    /*class Ridable //탈것
    {
        public virtual void Ride()
        {
            Console.WriteLine("탈것");
        }
    }*/

    interface ICar
    {
        void Run();
        void Ride();
    }

    interface IPlane
    {
        void Fly();
        void Ride();
    }

    class DronCar : IPlane, ICar
    {
        public void Fly()
        {
            Console.WriteLine("드론카 날다!");
        }

        public void Ride()
        {
            Run();
            Fly();
        }

        public void Run()
        {
            Console.WriteLine("드론카 달리다!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DronCar dreamCar = new DronCar();
            dreamCar.Ride();
        }
    }
}
