using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBookApp
{
    class DataFileManager
    {
        const string dataFileName = "address.dat";

        public List<AddressInfo> ReadData()
        {
            var listResult = new List<AddressInfo>();
            var filePath = Environment.CurrentDirectory + "\\" + dataFileName; // 데이터파일

            var sr = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read)); //Open
            while (sr.EndOfStream == false)
            {
                var temp = sr.ReadLine();
                // temp 잘라서 manager.listAddress 할당
                var splits = temp.Split("|");
                listResult.Add(new AddressInfo() { Name = splits[0], Phone = splits[1], Address = splits[2] });
            }
            sr.Close();

            return listResult;
        }

        public void WriteData(List<AddressInfo> list)
        {

            var filePath = Environment.CurrentDirectory + "\\" + dataFileName; // 데이터파일

            // 주소록을 다시 파일에 씀
            StreamWriter sw = new StreamWriter(new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write));
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    sw.WriteLine($"{item.Name}|{item.Phone}|{item.Address}");
                }
            }
            sw.Close();

        }
    }
}
