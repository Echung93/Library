using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class User
    {
    public User()
    {

    }
    public List<UserVO> loginUser(List<UserVO> userList)
    {
        userList = Controller.userList(userList);
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

    public void UserRegister()
    {
        List<UserVO> userList = new List<UserVO>();
        Stream ws;
        FileInfo fileUserInfo = new FileInfo("userInfomation.dat");

        if (!fileUserInfo.Exists)       //파일이 없을경우
        {
            ws = new FileStream("userInfomation.dat", FileMode.Create);
            ws.Close();
        }

        else
        {
            if (fileUserInfo.Length != 0)   //기존의 데이타를 가지고 있다면.
            {
                bool check = true;
                bool check1 = true;
                userList = Controller.userList(userList);
                ws = new FileStream("userInfomation.dat", FileMode.Open);
                BinaryFormatter serializer = new BinaryFormatter();
                Console.Clear();
                Console.Write("\r\n        회원 ID를 입력하세요(English and Number) : ");

                string UserId = MenuControl.Get().ReadString();

                while (check)
                {
                    int count = 0;

                    for (int i = 0; i < userList.Count; i++)
                    {
                        if (userList[i].UserId == UserId)
                        {
                            Console.Write("\r\n        이미 존재하는 ID입니다. 회원 ID를 다시 입력하세요(English and Number) : ");
                            UserId = MenuControl.Get().ReadString();
                            count++;
                            break;
                        }
                    }

                    if (count == 0)
                    {
                        check = false;
                    }
                }
                Console.Write("\r\n        회원 비밀 번호를 입력하세요(English and Number) : ");
                string UserPassword = MenuControl.Get().ReadPassword();
                Console.Write("\r\n        회원 이름 입력(공백없이 2~5 글자의 한글) : ");
                string UserName = MenuControl.Get().ReadString();
                while (check1)
                {
                    int count1 = 0;

                    for (int i = 0; i < userList.Count; i++)
                    {
                        if (userList[i].UserName == UserName)
                        {
                            Console.Write("\r\n        이미 존재하는 회원입니다. 회원 이름를 다시 입력하세요(English and Number) : ");
                            count1++;
                            break;
                        }
                    }

                    if (count1 == 0)
                    {
                        check1 = false;
                    }

                    else
                    {
                        UserName = Console.ReadLine();
                    }
                }

                Console.Write($"\r\n        {UserName} 님의 나이 입력 : ");
                string UserAge = MenuControl.Get().ReadNumber();
                Console.Write($"\r\n        {UserName} 님의 핸드폰 번호 입력('-' 제외하고 입력) : ");
                string UserPhoneNumber = MenuControl.Get().ReadNumber();
                Console.Write($"\r\n        {UserName} 님의 회원 주소 입력 : ");
                string UserAddress = MenuControl.Get().ReadString();
                userList.Add(new UserVO(UserId, UserPassword, UserName, UserAge, UserPhoneNumber, UserAddress));
                serializer.Serialize(ws, userList);     //직렬화(저장)
                ws.Close();
            }
        }
        //BinaryFormatter serializer = new BinaryFormatter();       
        //Console.Clear();
        //Console.Write("        회원 ID를 입력하세요(English and Number) : ");
        //string UserId = Console.ReadLine();
        //Console.Write("        회원 비밀 번호를 입력하세요(English and Number) : ");
        //string UserPassword = inputKey.ReadPassword();
        //Console.Write("        회원 이름 입력(공백없이 2~5 글자의 한글) : ");
        //string UserName = Console.ReadLine();
        //Console.Write($"        {UserName} 님의 나이 입력 : ");
        //string UserAge = Console.ReadLine();
        //Console.Write($"        {UserName} 님의 핸드폰 번호 입력('-' 제외하고 입력) : ");
        //string UserPhoneNumber = Console.ReadLine();
        //Console.Write($"        {UserName} 님의 회원 주소 입력 : ");
        //string UserAddress = Console.ReadLine();
        //userList.Add(new UserVO(UserId, UserPassword, UserName, UserAge, UserPhoneNumber, UserAddress));
        //serializer.Serialize(ws, userList);     //직렬화(저장)
        //ws.Close();

        //foreach (UserVO ui in userList)
        //{
        //    Console.WriteLine("       ------------------------------------------------------------------    ");
        //    Console.WriteLine("\r\n");
        //    Console.WriteLine("        회원 ID : " + ui.UserId);
        //    Console.WriteLine("        회원 비밀 번호 : " + ui.UserPassword);
        //    Console.WriteLine("        회원 이름 입력 : " + ui.UserName);
        //    Console.WriteLine($"        {ui.UserName} 나이 : " + ui.UserAge);
        //    Console.WriteLine($"        {ui.UserName} 핸드폰 번호 : " + ui.UserPhoneNumber);
        //    Console.WriteLine($"        {ui.UserName} 회원 주소 : " + ui.UserAddress);
        //    Console.WriteLine("\r\n");
        //}

        Console.ReadLine();
    }
}