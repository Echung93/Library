using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
public class Controller
{
    public static List<BookVO> bookList(List<BookVO> bookList)
    {
        bookList = new List<BookVO>();
        Stream ws;
        FileInfo fileBookInfo = new FileInfo("bookInfomation.dat");

        ////책만들기
        //ws = new FileStream("bookInfomation.dat", FileMode.Create);
        //BinaryFormatter serializer = new BinaryFormatter();
        //bookList.Add(new BookVO("ID001", "메타버스", "더큰내일센터", "김종현", "8000", 10));
        //serializer.Serialize(ws, bookList);     //직렬화(저장)
        //ws.Close();

        if (!fileBookInfo.Exists)       //파일이 없을경우
        {
            ws = new FileStream("bookInfomation.dat", FileMode.Create);
            ws.Close();
        }

        else
        {
            if (fileBookInfo.Length != 0)   //기존의 데이타를 가지고 있다면.
            {
                Stream rs = new FileStream("bookInfomation.dat", FileMode.Open); //일단 불러온다.
                BinaryFormatter deserializer = new BinaryFormatter();
                bookList = (List<BookVO>)deserializer.Deserialize(rs);       //역직렬화,리스트에 저장함.
                rs.Close();
                //ws = new FileStream("bookInfomation.dat", FileMode.Create);
                ////BinaryFormatter serializer = new BinaryFormatter();
                //bookList.Add(new BookVO("ID002", "다함께 아자", "더큰내일센터", "김종현", "9000", 10));
                //bookList.Add(new BookVO("ID003", "야근조아", "린랩", "백승민", "9000", 10));
                //bookList.Add(new BookVO("ID004", "닭가슴살조아", "린랩", "백승민", "10000", 10));
                //bookList.Add(new BookVO("ID005", "주식과코인", "린랩", "이충훈", "12000", 10));
                //bookList.Add(new BookVO("ID006", "인싸의삶", "린랩", "김지훈", "12000", 10));
                //bookList.Add(new BookVO("ID007", "스터디조아", "린랩", "김창연", "13000", 10));
                //bookList.Add(new BookVO("ID008", "벤쳐마루탈출기", "린랩", "김진양", "15000", 10));
                //serializer.Serialize(ws, bookList);     //직렬화(저장)
                //ws.Close();
            }
        }

        ////책리스트 불러오기
        //for (int i = 0; i < bookList.Count; i++)
        //{
        //    Console.WriteLine("       ------------------------------------------------------------------    ");
        //    Console.WriteLine("\r\n");
        //    Console.WriteLine("        책  ID 넘버 : " + bookList[i].BookIDNumber);
        //    Console.WriteLine("        책  이름 : " + bookList[i].BookName);
        //    Console.WriteLine("        책  저자 : " + bookList[i].BookAuthor);
        //    Console.WriteLine("        책  출판사 : " + bookList[i].BookPublisher);
        //    Console.WriteLine("        책  가격 : " + bookList[i].BookPrice);
        //    Console.WriteLine("        책  수량 : " + bookList[i].BookQuantity);
        //}

        //책리스트 불러오기(dat안에 있는 이름이랑 통일되어야함)        
        return bookList;
    }

    public static List<BookVO> testBookList(List<BookVO> testBookList)
    {
        testBookList = new List<BookVO>();
        Stream ws;
        FileInfo fileBookInfo = new FileInfo("bookInfomation.dat");

        ////책만들기
        //ws = new FileStream("bookInfomation.dat", FileMode.Create);
        //BinaryFormatter serializer = new BinaryFormatter();
        //bookList.Add(new BookVO("ID001", "메타버스", "더큰내일센터", "김종현", "8000", 10));
        //serializer.Serialize(ws, bookList);     //직렬화(저장)
        //ws.Close();

        if (!fileBookInfo.Exists)       //파일이 없을경우
        {
            ws = new FileStream("bookInfomation.dat", FileMode.Create);
            ws.Close();
        }

        else
        {
            if (fileBookInfo.Length != 0)   //기존의 데이타를 가지고 있다면.
            {
                Stream rs = new FileStream("bookInfomation.dat", FileMode.Open); //일단 불러온다.
                BinaryFormatter deserializer = new BinaryFormatter();
                testBookList = (List<BookVO>)deserializer.Deserialize(rs);       //역직렬화,리스트에 저장함.
                rs.Close();
            }
        }

        ////책리스트 불러오기
        //for (int i = 0; i < bookList.Count; i++)
        //{
        //    Console.WriteLine("       ------------------------------------------------------------------    ");
        //    Console.WriteLine("\r\n");
        //    Console.WriteLine("        책  ID 넘버 : " + bookList[i].BookIDNumber);
        //    Console.WriteLine("        책  이름 : " + bookList[i].BookName);
        //    Console.WriteLine("        책  저자 : " + bookList[i].BookAuthor);
        //    Console.WriteLine("        책  출판사 : " + bookList[i].BookPublisher);
        //    Console.WriteLine("        책  가격 : " + bookList[i].BookPrice);
        //    Console.WriteLine("        책  수량 : " + bookList[i].BookQuantity);
        //}

        //책리스트 불러오기(dat안에 있는 이름이랑 통일되어야함)        
        return testBookList;
    }

    public static List<UserVO> userList(List<UserVO> userList)
    {
        userList = new List<UserVO>();
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
                Stream rs = new FileStream("userInfomation.dat", FileMode.Open); //일단 불러온다.
                BinaryFormatter deserializer = new BinaryFormatter();
                userList = (List<UserVO>)deserializer.Deserialize(rs);       //역직렬화,리스트에 저장함.
                rs.Close();
            }
        }

        ////책리스트 불러오기
        //for (int i = 0; i < bookList.Count; i++)
        //{
        //    Console.WriteLine("       ------------------------------------------------------------------    ");
        //    Console.WriteLine("\r\n");
        //    Console.WriteLine("        책  ID 넘버 : " + bookList[i].BookIDNumber);
        //    Console.WriteLine("        책  이름 : " + bookList[i].BookName);
        //    Console.WriteLine("        책  저자 : " + bookList[i].BookAuthor);
        //    Console.WriteLine("        책  출판사 : " + bookList[i].BookPublisher);
        //    Console.WriteLine("        책  가격 : " + bookList[i].BookPrice);
        //    Console.WriteLine("        책  수량 : " + bookList[i].BookQuantity);
        //}

        //책리스트 불러오기(dat안에 있는 이름이랑 통일되어야함)        
        return userList;
    }

    public static List<BookHistoryVO> bookHistoryList(List<BookHistoryVO> bookHistoryList)
    {
        bookHistoryList = new List<BookHistoryVO>();
        Stream ws;
        FileInfo fileBookHistoryInfo = new FileInfo("bookHistory.dat");

        if (!fileBookHistoryInfo.Exists)       //파일이 없을경우
        {
            ws = new FileStream("bookHistory.dat", FileMode.Create);
            ws.Close();
        }


        else
        {
            if (fileBookHistoryInfo.Length != 0)   //기존의 데이타를 가지고 있다면.
            {
                Stream rs = new FileStream("bookHistory.dat", FileMode.Open); //일단 불러온다.
                BinaryFormatter deserializer = new BinaryFormatter();
                bookHistoryList = (List<BookHistoryVO>)deserializer.Deserialize(rs);       //역직렬화,리스트에 저장함.
                rs.Close();
            }
        }
    

        ////책리스트 불러오기
        //for (int i = 0; i < bookList.Count; i++)
        //{
        //    Console.WriteLine("       ------------------------------------------------------------------    ");
        //    Console.WriteLine("\r\n");
        //    Console.WriteLine("        책  ID 넘버 : " + bookList[i].BookIDNumber);
        //    Console.WriteLine("        책  이름 : " + bookList[i].BookName);
        //    Console.WriteLine("        책  저자 : " + bookList[i].BookAuthor);
        //    Console.WriteLine("        책  출판사 : " + bookList[i].BookPublisher);
        //    Console.WriteLine("        책  가격 : " + bookList[i].BookPrice);
        //    Console.WriteLine("        책  수량 : " + bookList[i].BookQuantity);
        //}

            //책리스트 불러오기(dat안에 있는 이름이랑 통일되어야함)        
        return bookHistoryList;
    }

    public void UpdateBookHistoryList(List<BookHistoryVO> bookHistoryList)
    {

        Stream ws = new FileStream("bookHistory.dat", FileMode.Open);
        BinaryFormatter serializer = new BinaryFormatter();
        serializer.Serialize(ws, bookHistoryList);     //직렬화(저장)
        ws.Close();
    }
    public void UpdataBookData(List<BookVO> bookList)
    {
        Stream ws = new FileStream("bookInfomation.dat", FileMode.Create);
        BinaryFormatter serializer = new BinaryFormatter();
        serializer.Serialize(ws, bookList);     //직렬화(저장)
        ws.Close();
    }
    public void UpdataUserData(List<UserVO> userList)
    {
        Stream ws = new FileStream("userInfomation.dat", FileMode.Create);
        BinaryFormatter serializer = new BinaryFormatter();
        serializer.Serialize(ws, userList);     //직렬화(저장)
        ws.Close();
    }
    public void HistoryOfBorrow(string bookName, string loginUser, List<BookHistoryVO> bookHistoryList)
    {
        BookHistoryVO bookHistoryVO = new BookHistoryVO(loginUser, bookName);
        bookHistoryVO.BorrowTime = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
        bookHistoryList.Add(bookHistoryVO);
    }

    public void HistoryOfReturn(string bookName, string loginUser, List<BookHistoryVO> bookHistoryList)
    {
        BookHistoryVO bookHistoryVO = new BookHistoryVO(loginUser, bookName);
        bookHistoryVO.ReturnTime = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
        bookHistoryList.Add(bookHistoryVO);
    }
}