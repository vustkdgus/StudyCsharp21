using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addr
{
    class InformationFind : Information
    {

        public void FindName()
        {
            string[] arr_name = { Information.Name };
            Console.Write("이름 입력:");
            string FName = Console.ReadLine();
            int findIndex = Array.FindIndex(arr_name, i => i == FName);
            if (findIndex == -1)
            {
                Console.WriteLine("존재하지 않는 이름입니다");
            }
            else
            {
                //Console.WriteLine(findIndex);

            }
        }
    }
}

