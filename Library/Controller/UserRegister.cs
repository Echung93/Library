using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
class UserRegister
{
    public List<UserVO> userList(List<UserVO> userList)
    {
        userList = new List<UserVO>();
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
                Stream rs = new FileStream("userInfomation.dat", FileMode.Open); //일단 불러온다.
                BinaryFormatter deserializer = new BinaryFormatter();
                userList = (List<UserVO>)deserializer.Deserialize(rs);       //역직렬화,리스트에 저장함.
                rs.Close();
                ws = new FileStream("userInfomation.dat", FileMode.Open);
                BinaryFormatter serializer = new BinaryFormatter();
                Console.Clear();
                Console.Write("        회원 ID를 입력하세요(English and Number) : ");
                string UserId = Console.ReadLine();
                Console.Write("        회원 비밀 번호를 입력하세요(English and Number) : ");
                string UserPassword = inputKey.ReadPassword();
                Console.Write("        회원 이름 입력(공백없이 2~5 글자의 한글) : ");
                string UserName = Console.ReadLine();
                Console.Write($"        {UserName} 님의 나이 입력 : ");
                string UserAge = Console.ReadLine();
                Console.Write($"        {UserName} 님의 핸드폰 번호 입력('-' 제외하고 입력) : ");
                string UserPhoneNumber = Console.ReadLine();
                Console.Write($"        {UserName} 님의 회원 주소 입력 : ");
                string UserAddress = Console.ReadLine();
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

        return userList;
    }

}