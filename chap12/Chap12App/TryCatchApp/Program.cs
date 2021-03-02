using System;

namespace TryCatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int x = 108, y = 0;
            int result = 0;

            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine($"{i} 번째 값 : {arr[1]}");
                }

                result = x / y;
                Console.WriteLine($"결과는 {result}");
            }
            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine($"예외발생 : {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }

            Console.WriteLine($"나머지 일처리 계속...");

            string strVal = "Hello World";
            string splitVal = strVal.Substring(6, 5);
            Console.WriteLine($"자른 문자 : {splitVal}");

            try
            {

            }
            catch (ArgumentOutOfRangeException ex)
            {

                Console.WriteLine($"원본문자열이 비어있습니다. 값을 입력하세요{ex.Message}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"원본문자열을 초기화하세요{ex.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"기타 예외발생{ex.Message}");
            }

            Console.WriteLine($"일처리 또 계속...");
        }
    }
}
