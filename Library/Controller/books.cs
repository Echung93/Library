using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Books
{
    ui ui = new ui();
    public Books()
        {

        }
    public void searchBook(List<BookVO> bookList)
    {
        bool check = true;
        ui.printScreen1_1();
        string num = Console.ReadLine();
        Console.Clear();
        Controller ct = new Controller();
        bookList = Controller.bookList(bookList);

        int count = 0;

        if (num == "1")
        {
            ui.printScreen1_1_1();
            while (check)
            {
                string input = MenuControl.Get().ReadString();
                if (input == "\0")
                {
                    break;
                }
                while (check)
                    Console.WriteLine("        검색 목록");
                for (int i = 0; i < bookList.Count; i++)
                {
                    if (bookList[i].BookName.Contains(input))
                    {
                        Console.WriteLine("       ------------------------------------------------------------------    ");
                        Console.WriteLine("\r\n");
                        Console.WriteLine("        책  ID 넘버 : " + bookList[i].BookIDNumber);
                        Console.WriteLine("        책  이름 : " + bookList[i].BookName);
                        Console.WriteLine("        책  저자 : " + bookList[i].BookAuthor);
                        Console.WriteLine("        책  출판사 : " + bookList[i].BookPublisher);
                        Console.WriteLine("        책  가격 : " + bookList[i].BookPrice);
                        Console.WriteLine("        책  수량 : " + bookList[i].BookQuantity);
                        Console.WriteLine("\r\n");
                        count++;

                    }
                }
                if (count == 0)
                {
                    Console.Write("        검색하신 책이 없습니다. 다시 입력해주세요. : ");
                }

                else
                {
                    check = false;
                }
            }
        }

        else if (num == "2")
        {
            ui.printScreen1_1_2();
            while (check)
            {
                string input = MenuControl.Get().ReadString();
                if (input == "\0")
                {
                    break;
                }
                Console.WriteLine("        검색 목록");
                for (int i = 0; i < bookList.Count; i++)
                {
                    if (bookList[i].BookAuthor.Contains(input))
                    {
                        Console.WriteLine("       ------------------------------------------------------------------    ");
                        Console.WriteLine("\r\n");
                        Console.WriteLine("        책  ID 넘버 : " + bookList[i].BookIDNumber);
                        Console.WriteLine("        책  이름 : " + bookList[i].BookName);
                        Console.WriteLine("        책  저자 : " + bookList[i].BookAuthor);
                        Console.WriteLine("        책  출판사 : " + bookList[i].BookPublisher);
                        Console.WriteLine("        책  가격 : " + bookList[i].BookPrice);
                        Console.WriteLine("        책  수량 : " + bookList[i].BookQuantity);
                        Console.WriteLine("\r\n");
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.Write("        검색하신 책이 없습니다. 다시 입력해주세요. : ");
                }

                else
                {
                    check = false;
                }
            }
        }

        else if (num == "3")
        {
            ui.printScreen1_1_3();
            while (check)
            {
                string input = MenuControl.Get().ReadString();
                if (input == "\0")
                {
                    break;
                }
                Console.WriteLine("        검색 목록");
                for (int i = 0; i < bookList.Count; i++)
                {
                    if (bookList[i].BookPublisher.Contains(input))
                    {
                        Console.WriteLine("       ------------------------------------------------------------------    ");
                        Console.WriteLine("\r\n");
                        Console.WriteLine("        책  ID 넘버 : " + bookList[i].BookIDNumber);
                        Console.WriteLine("        책  이름 : " + bookList[i].BookName);
                        Console.WriteLine("        책  저자 : " + bookList[i].BookAuthor);
                        Console.WriteLine("        책  출판사 : " + bookList[i].BookPublisher);
                        Console.WriteLine("        책  가격 : " + bookList[i].BookPrice);
                        Console.WriteLine("        책  수량 : " + bookList[i].BookQuantity);
                        Console.WriteLine("\r\n");
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.Write("        검색하신 책이 없습니다. 다시 입력해주세요. : ");
                }

                else
                {
                    check = false;
                }
            }
        }

        else
        {

        }



    }

    public List<BookVO> borrowBooks(List<BookVO> bookList) 
    {
        bool check = true;
        bool check1 = true;
        Console.Clear();
        Controller ct = new Controller();
        bookList = Controller.bookList(bookList);
        List<BookVO> searchList = new List<BookVO>();
        List<BookVO> borrowList = new List<BookVO>();

        int count = 0;

        ui.printScreen1_1_1();
        while (check)
        {
            string input = MenuControl.Get().ReadString();
            if (input == "\0")
            {
                break;
            }
            Console.WriteLine("        검색 목록");
            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].BookName.Contains(input))
                {
                    Console.WriteLine("       ------------------------------------------------------------------    ");
                    Console.WriteLine("\r\n");
                    Console.WriteLine("        책  ID 넘버 : " + bookList[i].BookIDNumber);
                    Console.WriteLine("        책  이름 : " + bookList[i].BookName);
                    Console.WriteLine("        책  저자 : " + bookList[i].BookAuthor);
                    Console.WriteLine("        책  출판사 : " + bookList[i].BookPublisher);
                    Console.WriteLine("        책  가격 : " + bookList[i].BookPrice);
                    Console.WriteLine("        책  수량 : " + bookList[i].BookQuantity);
                    Console.WriteLine("\r\n");
                    count++;
                    searchList.Add(bookList[i]);
                }
            }
            if (count == 0)
            {
                Console.Write("        검색하신 책이 없습니다. 다시 입력해주세요. : ");
            }

            else
            {
                check = false;
            }
        }
       
            Console.Write("        대출 하시려는 책의 ID넘버를 입력하세요(ex.ID1234) : ");
        while (check1)
        {
            string bookname = MenuControl.Get().ReadString();
            if (bookname == "\0")
            {
                break;
            }
            int count1 = 0;
            for (int j = 0; j < searchList.Count; j++)
            {
                if (searchList[j].BookIDNumber == bookname)
                {
                    //Console.WriteLine("       ------------------------------------------------------------------    ");
                    //Console.WriteLine("\r\n");
                    //Console.WriteLine("        책  ID 넘버   : " + bookList[j].BookIDNumber);
                    //Console.WriteLine("        책  이름 : " + bookList[j].BookName);
                    //Console.WriteLine("        책  저자 : " + bookList[j].BookAuthor);
                    //Console.WriteLine("        책  출판사 : " + bookList[j].BookPublisher);
                    //Console.WriteLine("        책  가격 : " + bookList[j].BookPrice);
                    //Console.WriteLine("        책  수량 : " + bookList[j].BookQuantity);
                    //Console.WriteLine("\r\n");
                    borrowList.Add(searchList[j]);
                    Console.Write($"        책 '{searchList[j].BookName}' 대출 완료 ! ");
                    searchList[j].BookQuantity--;
                    count1++;                   
                }
            }

            if (count1 == 0)
            {
                Console.Write("        대출 하시려는 책의 유효한 ID넘버를 입력하세요(ex.ID1234) : ");
            }

            else
            {
                check1 = false;
            }
        }
        return searchList;
    }
}
