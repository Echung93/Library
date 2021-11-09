using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
class UserList
{
    public UserList()
    {
        List<UserVO> userList = new List<UserVO>();
        Stream ws;
        FileInfo fileBookInfo = new FileInfo("userInfomation.dat");

        if (!fileBookInfo.Exists)       //파일이 없을경우
        {
            ws = new FileStream("bookInfomation.dat", FileMode.Create);
            ws.Close();
        }

        else
        {
            if (fileBookInfo.Length != 0)   //기존의 데이타를 가지고 있다면.
            {
                Stream rs = new FileStream("userInfomation.dat", FileMode.Open); //일단 불러온다.
                BinaryFormatter deserializer = new BinaryFormatter();
                userList = (List<UserVO>)deserializer.Deserialize(rs);       //역직렬화,리스트에 저장함.
                rs.Close();
            }
        }
    }
        public void UpdataUserData(List<UserVO> userList)
        {
            Stream ws = new FileStream("userInfomation.dat", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(ws, userList);     //직렬화(저장)
            ws.Close();
        }
    }
