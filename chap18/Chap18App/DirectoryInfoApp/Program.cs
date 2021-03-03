using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string strDir;
            strDir = @"C:\Program Files\Bandizip"; // 폴더 정보 확인 경로

            Console.WriteLine($"{strDir} 디렉토리 정보");
            /*var diretories = (from dir in Directory.GetDirectories(strDir)
                              let info = new DirectoryInfo(dir)
                              select new
                              {
                                  Name = info.Name,
                                  Attribute = info.Attributes
                              }).ToList();*/

            var diretories = new DirectoryInfo(strDir).GetDirectories();
            foreach (var item in diretories)
            {
                Console.WriteLine($"{item.Name} : {item.Attributes}");
            }

            Console.WriteLine($"{strDir} 내 폴더 정보");
            var files = new DirectoryInfo(strDir).GetFiles();
            foreach (var item in files)
            {
                Console.WriteLine($"{item.Name} : {item.Attributes} : {(item.Length/ 1024):#,###}KB : {item.Extension}");
            }
        }
    }
}
