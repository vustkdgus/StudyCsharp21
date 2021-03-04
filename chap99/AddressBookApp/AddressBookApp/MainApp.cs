using System;
using System.Collections.Generic;
using System.IO;

namespace AddressBookApp
{

    class MainApp
    {

        static void Main(string[] args)
        {

            try
            {
                AddressManager manager = new AddressManager();
                manager.listAddress = new List<AddressInfo>();

                DataFileManager fileManager = new DataFileManager();
                manager.listAddress = fileManager.ReadData();



                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(Environment.CurrentDirectory);
                    manager.PrintMenu();
                    int menuNum = manager.SelectMenu();

                    switch (menuNum)
                    {
                        case 0: // 메뉴선택 실패, 메뉴로 돌아감
                            break;

                        case 1: // 주소입력 화면 전환
                            manager.InputAddress();
                            Console.Clear();

                            break;
                        case 2: // 주소검색
                            Console.Clear();
                            manager.SearchAddress();

                            break;
                        case 3: // 주소수정
                            Console.Clear();
                            manager.UpdateAddress();

                            break;
                        case 4: // 주소삭제
                            Console.Clear();
                            manager.DeleteAddress();

                            break;
                        case 5: // 주소 전체 출력
                            Console.Clear();
                            manager.PrintAllAddress();

                            break;
                        case 6: //종료
                            fileManager.WriteData(manager.listAddress);
                            Environment.Exit(0);

                            break;
                        default: // 0은 여기서처리
                                 // 아무 로직 없음
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
        }
    }
}
