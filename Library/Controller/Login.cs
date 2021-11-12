using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Login
{
    //    public Login(List<UserVO> userList)
    //    {
    //        Console.Clear();
    //        bool check = true;
    //        bool check1 = true;
    //        ui.Get().printScreenEtc();

    //        Console.Write("        회원 ID를 입력하세요(English and Number) : ");
    //        while (check)
    //        {
    //            int count = 0;
    //            string id = Console.ReadLine();
    //            for (int i = 0; i < userList.Count; i++)
    //            {
    //                if (userList[i].UserId == (id))
    //                {
    //                    Console.Write("        회원 비밀 번호를 입력하세요(English and Number) : ");
    //                    while (check1)
    //                    {
    //                        string pw = inputKey.ReadPassword();
    //                        if (userList[i].UserPassword == (pw))
    //                        {
    //                            Console.Write("        로그인 성공");
    //                            check = false;
    //                            check1 = false;
    //                            break;
    //                        }

    //                        else
    //                        {
    //                            Console.Clear();
    //                            ui.Get().printScreenEtc();
    //                            Console.Write("        부정확한 비밀번호 입니다. 다시 입력하세요(English and Number) : ");
    //                            check = false;
    //                        }
    //                    }
    //                }
    //                else
    //                {
    //                    count++;
    //                }
    //            }
    //            if (count == userList.Count)
    //            {
    //                Console.Clear();
    //                ui.Get().printScreenEtc();
    //                Console.Write("        존재하지 않는 ID입니다. 다시 입력하세요(English and Number) : ");
    //            }
    //        }
    //    }

    public List<UserVO> loginUser(List<UserVO> userList)
    {
        Console.Clear();
        bool check = true;
        bool check1 = true;
        List<UserVO> loginUser = new List<UserVO>();
        ui.Get().printScreenEtc();
        string id;
        Console.Write("        회원 ID를 입력하세요(English and Number) : ");
        while (check)
        {
            int count = 0;
            id = MenuControl.Get().ReadString();

            if (id == "\0")
            {
                check = false;
                break;
            }

            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i].UserId == (id))
                {
                    Console.Write("\r\n        회원 비밀 번호를 입력하세요(English and Number) : ");
                    while (check1)
                    {
                        string pw = MenuControl.Get().ReadPassword();
                        if (userList[i].UserPassword == (pw))
                        {
                            Console.Write("        로그인 성공");
                            loginUser.Add(userList[i]);
                            check = false;
                            check1 = false;

                        }

                        else
                        {
                            Console.Clear();
                            ui.Get().printScreenEtc();
                            Console.Write("        부정확한 비밀번호 입니다. 다시 입력하세요(English and Number) : ");
                            check = false;
                        }
                    }
                }
                else
                {
                    count++;
                }
            }

            if (count == userList.Count)
            {
                Console.Clear();
                ui.Get().printScreenEtc();
                Console.Write("        존재하지 않는 ID입니다. 다시 입력하세요(English and Number) : ");
            }
            
        }
        return loginUser;
    }

    public bool loginManager(string input)
    {
        while (true)
        {
            if (input == "byuk")
            {
                return false;
            }
            else
            {
                Console.Write("\r\n         관리자 비밀 번호를 다시 입력 하시오 : ");
                input = MenuControl.Get().ReadPassword();
            }
        }
    }


}



