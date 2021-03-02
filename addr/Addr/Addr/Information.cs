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
        public static Array arrayAddress { get; set; }

        static void Main()
        {
            List<int> list = new List<int>();

            list.Add(2);
            list.Add(3);
            list.Add(5);
            list.Add(7);
        }



        public void Insert()
        {
            Console.Write("이름 입력:");
            Information.Name = Console.ReadLine();
            Console.Write("전화 입력:");
            Information.Phone = Console.ReadLine();
            Console.Write("주소 입력:");
            Information.Address = Console.ReadLine();
            List<string> addr1 = new List<string>();
            addr1.name = Name;
            addr1.phone = Phone;
            addr1.address = Address;
            arrayAddress.Add(addr);
        }
 
    }
}
