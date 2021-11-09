using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Login
{
    ui ui = new ui();
    public Login(List<UserVO> userList)
    {
        ui.printScreenEtc();
        Console.Write("        회원 ID를 입력하세요(English and Number) : ");
        while (true)
        {

            string id = Console.ReadLine();
            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i].UserId == (id))
                {
                    Console.Write("        회원 비밀 번호를 입력하세요(English and Number) : ");
                    while (true)
                    {
                        string pw = inputKey.ReadPassword();
                        if (userList[i].UserPassword == (pw))
                        {
                            Console.Write("        로그인 성공");
                            break;
                        }

                        else
                        {
                            Console.Clear();
                            ui.printScreenEtc();
                            Console.Write("        부정확한 비밀번호 입니다. 다시 입력하세요(English and Number) : ");
                        }
                    }
                    break;
                }

                else
                {
                    Console.Clear();
                    ui.printScreenEtc();
                    Console.Write("        존재하지 않는 ID입니다. 다시 입력하세요(English and Number) : ");
                }
                break;
            }
            break;
        }
    }
}



