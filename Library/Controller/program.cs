using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;

class program
{
    static void Main(string[] args)
    {
        Controller ct = new Controller();
        UserRegister ur = new UserRegister();
        List<BookVO> bookList = new List<BookVO>();
        List<UserVO> userList = new List<UserVO>();
        bookList = Controller.bookList(bookList);
        userList = Controller.userList(userList);
        //foreach (BookVO bv in bookList)
        //{
        //    Console.WriteLine("       ------------------------------------------------------------------    ");
        //    Console.WriteLine("\r\n");
        //    Console.WriteLine("        책  ID 넘버 : " + bv.BookIDNumber);
        //    Console.WriteLine("        책  이름 : " + bv.BookName);
        //    Console.WriteLine("        책  저자 : " + bv.BookAuthor);
        //    Console.WriteLine("        책  출판사 : " + bv.BookPublisher);
        //    Console.WriteLine("        책  가격 : " + bv.BookPrice);
        //    Console.WriteLine("        책  수량 : " + bv.BookQuantity);
        //    Console.WriteLine("\r\n");
        //}

        //Console.WriteLine("       ------------------------------------------------------------------    ");
        //Console.WriteLine("\r\n");
        //Console.WriteLine($"                등록된 총 책의 권 수는: {bookList.Count} 권 입니다");

        //new ui().mainMenu();

        //userList = ur.userList(userList);
        foreach (UserVO uv in userList)
        {
            Console.WriteLine("       ------------------------------------------------------------------    ");
            Console.WriteLine("\r\n");
            Console.WriteLine("        회원 ID : " + uv.UserId);
            Console.WriteLine("        회원 비밀 번호 : " + uv.UserPassword);
            Console.WriteLine("        회원 이름 입력 : " + uv.UserName);
            Console.WriteLine($"        {uv.UserName} 나이 : " + uv.UserAge);
            Console.WriteLine($"        {uv.UserName} 핸드폰 번호 : " + uv.UserPhoneNumber);
            Console.WriteLine($"        {uv.UserName} 회원 주소 : " + uv.UserAddress);
            Console.WriteLine("\r\n");
        }

        //books bs = new books();
        //bs.borrowBooks(bookList);

        Login lo = new Login(userList);
    }
}