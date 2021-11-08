using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;

namespace Library
{
    public class Controller
    {
        public Controller()
        {
            List<BookVO> bookList = new List<BookVO>();
            Stream ws;
            FileInfo fileBookInfo = new FileInfo("bookInfomation.dat");

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
                }
            }

            ////책리스트 불러오기
            //for (int i = 0; i < bookList.Count; i++)
            //{
            //    Console.WriteLine("        책  ID 넘버 : " + bookList[i].BookIDNumber);
            //    Console.WriteLine("        책  이름 : " + bookList[i].BookName);
            //    Console.WriteLine("        책  저자 : " + bookList[i].BookAuthorName);
            //    Console.WriteLine("        책  출판사 : " + bookList[i].BookPublisherName);
            //    Console.WriteLine("        책  가격 : " + bookList[i].BookPrice); 
            //    Console.WriteLine("        책  수량 : " + bookList[i].BookQuantity);
            //}

            //책리스트 불러오기 (dat안에 있는 이름이랑 통일되어야함)
            foreach (BookVO bi in bookList)
            {
                Console.WriteLine("       ------------------------------------------------------------------    ");
                Console.WriteLine("\r\n");
                Console.WriteLine("        책  ID 넘버 : " + bi.BookIDNumber);
                Console.WriteLine("        책  이름 : " + bi.BookName);
                Console.WriteLine("        책  저자 : " + bi.BookAuthorName);
                Console.WriteLine("        책  출판사 : " + bi.BookPublisherName);
                Console.WriteLine("        책  가격 : " + bi.BookPrice);
                Console.WriteLine("        책  수량 : " + bi.BookQuantity);
                Console.WriteLine("\r\n");
            }
            Console.WriteLine("       ------------------------------------------------------------------    ");
            Console.WriteLine("\r\n");
            Console.WriteLine($"                등록된 총 책의 권 수는: {bookList.Count} 권 입니다");
        }

        public void UpdataBookData(List<BookVO> bookList)
        {
            Stream ws = new FileStream("bookInfomation.dat", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(ws, bookList);     //직렬화(저장)
            ws.Close();
        }
    }
}