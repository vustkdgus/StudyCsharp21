using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addr
{
     
    class Adress
    {
        public static string Name;
        public static string Phone;
        public static string Address;
    }

    class Program
    {
      


        static void Main(string[] args)
        {
           // string[,] arr = { { Information.Name, Information.Phone, Information.Address } };


            Console.WriteLine("------------------------");
            Console.WriteLine("0. 주소 입력");
            Console.WriteLine("1. 주소 검색");
            Console.WriteLine("2. 주소 수정");
            Console.WriteLine("3. 주소 삭제");
            Console.WriteLine("4. 주소 전체출력");
            Console.WriteLine("5. 프로그램 종료");
            Console.WriteLine("------------------------");
            Console.Write("메뉴를 선택하세요 >>>" );
            string number1 = Console.ReadLine();
            int number2 = Convert.ToInt32(number1);
            switch (number2)
            {
                case 0:
                    Information information = new Information();
                    information.Insert();
                    /*string[,] arr = { { Information.Name, Information.Phone, Information.Address } };
                    Console.Write("이름 입력:");
                    InformationFind informationFind = new InformationFind();
                    string FName = Console.ReadLine();
                    informationFind.FindName();*/


                    break;
                case 1:
                   /* Console.Write("이름 입력:");
                    InformationFind informationFind = new InformationFind();
                    string FName = Console.ReadLine();
                    informationFind.FindName();*/
                    // int findIndex = Array.FindIndex(arr[], i => i == FName );
                    /*for (int i = 0; i < 1; ++i)
                    {
                        for (int j = 0; j < 3; ++j)
                        {
                            Console.Write($" {arr[i, j]}");
                        }
                        Console.WriteLine("");
                    }*/
                    break;
                case 2:
                    Console.WriteLine("2이 입력되었습니다.");
                    break;
                case 3:
                    Console.WriteLine("3가 입력되었습니다.");
                    break;
                case 4:
                   /* for (int i = 0; i < 1; ++i)
                    {
                        for (int j = 0; j < 3; ++j)
                        {
                            Console.Write($" {arr[i, j]}");
                        }
                        Console.WriteLine("");
                    }*/
                    break;
                case 5:
                    Console.WriteLine("프로그램이 종료됩니다.");
                    break;
                default:
                    Console.WriteLine("1부터 5까지의 숫자를 입력바람.");
                    break;
            }

        }
    }
}
