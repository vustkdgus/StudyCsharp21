using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintProfile("ㅇㅇㅇ", "010-2222-3333");

            if (PrintProfile(null, "010-2222-3333") == -1)
            {
                Console.WriteLine("프로필 출력시 오류가 발생하였습니다.");
            }
        }

        public static int PrintProfile(string name, string phone)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("이름을 정확히 입력하세요.");
                return -1;
            }
            // 프로필 출력
            Console.WriteLine($"이름 : {name}, 폰번호 : {phone}");
            return 0;
        }
    }
}
