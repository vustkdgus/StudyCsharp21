using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap04App
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = 37656234;
            if (values % 2 == 0)
            {
                Console.WriteLine("짝수");
            }
            else
            {
                Console.WriteLine("홀수");
            }

            if (values % 3 == 0)
            {
                Console.WriteLine("3의배수");
            }
            else
            {
                Console.WriteLine("3의 배수가 아닙니다");
            }
        }
    }
}
