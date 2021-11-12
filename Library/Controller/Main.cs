using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class Main
{
    public Main()
    {
        List<UserVO> userList = new List<UserVO>();
        Stream ws;
        FileInfo fileUserInfo = new FileInfo("userInfomation.dat");

        //ws = new FileStream("userInfomation.dat", FileMode.Create);
        //BinaryFormatter serializer = new BinaryFormatter();
        //userList.Add(new UserVO("kty309", "kty309", "이충훈", "24", "01044442222", "구좌"));
        //serializer.Serialize(ws, userList);     //직렬화(저장)
        //ws.Close();

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
