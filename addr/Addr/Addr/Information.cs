using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addr
{
    class Information
    {
        public static string Name { get; set; }
        public static string Phone { get; set; }
        public static string Address { get; set; }
        public static Array arr { get; set; }

        public void Insert()
        {
            Console.Write("이름 입력:");
            Information.Name = Console.ReadLine();
            Console.Write("전화 입력:");
            Information.Phone = Console.ReadLine();
            Console.Write("주소 입력:");
            Information.Address = Console.ReadLine();
            string[,] arr = { { Information.Name, Information.Phone, Information.Address } };
            string[] arr_name = { Information.Name };
        }
 
    }
}
