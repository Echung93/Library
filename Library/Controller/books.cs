using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Books
{
    public Books()
    {

    }
    public void searchBook(List<BookVO> testBookList)
    {
        bool check = true;


        while (check)
        {
            Console.Clear();
            ui.Get().printScreen1_1();
            bool check1 = true;
            string num = MenuControl.Get().ReadString();
            if (num == "\0")
            {
                check = false;
                break;
            }
            Console.Clear();
            Controller ct = new Controller();
            testBookList = Controller.testBookList(testBookList);

            int count = 0;

            if (num == "1")
            {
                ui.Get().printScreen1_1_1();

                string input = MenuControl.Get().ReadString();
                if (input == "\0")
                {
                    break;
                }
                while (check1)
                {
                    Console.WriteLine("\r\n        검색 목록");
                    for (int i = 0; i < testBookList.Count; i++)
                    {
                        if (testBookList[i].BookName.Contains(input))
                        {
                            Console.WriteLine("       ------------------------------------------------------------------    ");
                            Console.WriteLine("\r\n");
                            Console.WriteLine("        책  ID 넘버 : " + testBookList[i].BookIDNumber);
                            Console.WriteLine("        책  이름 : " + testBookList[i].BookName);
                            Console.WriteLine("        책  저자 : " + testBookList[i].BookAuthor);
                            Console.WriteLine("        책  출판사 : " + testBookList[i].BookPublisher);
                            Console.WriteLine("        책  가격 : " + testBookList[i].BookPrice);
                            Console.WriteLine("        책  수량 : " + testBookList[i].BookQuantity);
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
                        check1 = false;
                        Console.WriteLine("        뒤로가려면 ESC를 눌러주세요. ");
                        string input1 = MenuControl.Get().ReadESC();
                        if (input1 == "\0")
                        {
                            break;
                        }
                    }
                }
            }

            else if (num == "2")
            {
                ui.Get().printScreen1_1_2();
                while (check1)
                {
                    string input = MenuControl.Get().ReadString();
                    if (input == "\0")
                    {
                        break;
                    }
                    Console.WriteLine("\r\n        검색 목록");
                    for (int i = 0; i < testBookList.Count; i++)
                    {
                        if (testBookList[i].BookAuthor.Contains(input))
                        {
                            Console.WriteLine("       ------------------------------------------------------------------    ");
                            Console.WriteLine("\r\n");
                            Console.WriteLine("        책  ID 넘버 : " + testBookList[i].BookIDNumber);
                            Console.WriteLine("        책  이름 : " + testBookList[i].BookName);
                            Console.WriteLine("        책  저자 : " + testBookList[i].BookAuthor);
                            Console.WriteLine("        책  출판사 : " + testBookList[i].BookPublisher);
                            Console.WriteLine("        책  가격 : " + testBookList[i].BookPrice);
                            Console.WriteLine("        책  수량 : " + testBookList[i].BookQuantity);
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
                        check1 = false;
                        Console.WriteLine("        뒤로가려면 ESC를 눌러주세요. ");
                        string input1 = MenuControl.Get().ReadESC();
                        if (input1 == "\0")
                        {
                            break;
                        }
                    }
                }
            }

            else if (num == "3")
            {
                ui.Get().printScreen1_1_3();
                while (check1)
                {
                    string input = MenuControl.Get().ReadString();
                    if (input == "\0")
                    {
                        break;
                    }
                    Console.WriteLine("\r\n        검색 목록");
                    for (int i = 0; i < testBookList.Count; i++)
                    {
                        if (testBookList[i].BookPublisher.Contains(input))
                        {
                            Console.WriteLine("       ------------------------------------------------------------------    ");
                            Console.WriteLine("\r\n");
                            Console.WriteLine("        책  ID 넘버 : " + testBookList[i].BookIDNumber);
                            Console.WriteLine("        책  이름 : " + testBookList[i].BookName);
                            Console.WriteLine("        책  저자 : " + testBookList[i].BookAuthor);
                            Console.WriteLine("        책  출판사 : " + testBookList[i].BookPublisher);
                            Console.WriteLine("        책  가격 : " + testBookList[i].BookPrice);
                            Console.WriteLine("        책  수량 : " + testBookList[i].BookQuantity);
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
                        check1 = false;
                        Console.WriteLine("        뒤로가려면 ESC를 눌러주세요. ");
                        string input1 = MenuControl.Get().ReadESC();
                        if (input1 == "\0")
                        {
                            break;
                        }
                    }
                }
            }

            else if (num == "4")
            {
                break;
            }
        }
    }
    public List<BookVO> borrowBooks(List<BookVO> testBookList, List<UserVO> loginUser, List<UserVO> userList, List<BookHistoryVO> bookHistoryList)
    {
        bool check = true;
        bool check1 = true;
        Console.Clear();
        Controller ct = new Controller();
        //bookList = Controller.bookList(bookList);
        userList = Controller.userList(userList);
        testBookList = Controller.testBookList(testBookList);
        bookHistoryList = Controller.bookHistoryList(bookHistoryList);
        List<BookVO> searchList = new List<BookVO>();
        List<BookVO> borrowList = new List<BookVO>();
        List<UserVO> userBorrow = new List<UserVO>();
        int count = 0;

        ui.Get().printScreen1_1_1();
        while (check)
        {
            string input = MenuControl.Get().ReadString();

            if (input == "\0")
            {
                break;
            }
            Console.WriteLine("\r\n        검색 목록");
            for (int i = 0; i < testBookList.Count; i++)
            {
                if (testBookList[i].BookName.Contains(input))
                {
                    Console.WriteLine("       ------------------------------------------------------------------    ");
                    Console.WriteLine("\r\n");
                    Console.WriteLine("        책  ID 넘버 : " + testBookList[i].BookIDNumber);
                    Console.WriteLine("        책  이름 : " + testBookList[i].BookName);
                    Console.WriteLine("        책  저자 : " + testBookList[i].BookAuthor);
                    Console.WriteLine("        책  출판사 : " + testBookList[i].BookPublisher);
                    Console.WriteLine("        책  가격 : " + testBookList[i].BookPrice);
                    Console.WriteLine("        책  수량 : " + testBookList[i].BookQuantity);
                    Console.WriteLine("\r\n");
                    count++;
                    searchList.Add(testBookList[i]);
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
                    for (int k = 0; k < loginUser.Count; k++)
                    {
                        for (int l = 0; l < userList.Count; l++)
                            if (userList[l].UserId == loginUser[k].UserId)
                            {
                                if (userList[l].BorrowedBookCount == 0)
                                {
                                    //Console.WriteLine("       ------------------------------------------------------------------    ");
                                    //Console.WriteLine("\r\n");
                                    //Console.WriteLine("        책  ID 넘버   : " + bookList[j].BookIDNumber);
                                    //Console.WriteLine("        책  이름 : " + bookList[j].BookName);
                                    //Console.WriteLine("        책  저자 : " + bookList[j].BookAuthor);
                                    //Console.WriteLine("        책  출판사 : " + bookList[j].BookPublisher);
                                    //Console.WriteLine("        책  가격 : " + bookList[j].BookPrice);
                                    //Console.WriteLine("        책  수량 : " + bookList[j].BookQuantity);
                                    Console.WriteLine("\r\n");
                                    Console.Write($"        책 '{searchList[j].BookName}' 대출 완료 ! ");
                                    userList[l].BorrowedBookList += searchList[j].BookName + " ";
                                    userList[l].BorrowedBookCount++;
                                    loginUser[0].BorrowedBookCount++;
                                    for (int d = 0; d < testBookList.Count; d++)
                                    {
                                        if (testBookList[d].BookName == searchList[j].BookName)
                                        {
                                            testBookList[d].BookQuantity--;
                                        }
                                    }
                                    Controller controller = new Controller();
                                    controller.UpdataUserData(userList);
                                    controller.HistoryOfBorrow(searchList[j].BookName, loginUser[0].UserName, bookHistoryList);
                                    controller.UpdateBookHistoryList(bookHistoryList);
                                    check1 = false;
                                }

                                else if (!userList[l].BorrowedBookList.Contains(searchList[j].BookName))
                                {
                                    Console.WriteLine("\r\n");
                                    Console.Write($"        책 '{searchList[j].BookName}' 대출 완료 ! ");
                                    userList[l].BorrowedBookList += searchList[j].BookName + " ";
                                    userList[l].BorrowedBookCount++;
                                    loginUser[0].BorrowedBookCount++;
                                    for (int d = 0; d < testBookList.Count; d++)
                                    {
                                        if (testBookList[d].BookName == searchList[j].BookName)
                                        {
                                            testBookList[d].BookQuantity--;
                                        }
                                    }
                                    loginUser[0].BorrowedBookCount++;
                                    Controller controller = new Controller();
                                    controller.UpdataUserData(userList);
                                    controller.HistoryOfBorrow(searchList[j].BookName, loginUser[0].UserName, bookHistoryList);
                                    controller.UpdateBookHistoryList(bookHistoryList);
                                    check1 = false;

                                }

                                else
                                {
                                    Console.Write("\r\n        이미 대출하신 책입니다. 대출 목록을 확인해 보세요. ");
                                }
                            }
                    }
                    borrowList.Add(searchList[j]);
                }
            }



            //foreach (UserVO uv in loginUser)
            //{
            //    Console.WriteLine("       ------------------------------------------------------------------    ");
            //    Console.WriteLine("\r\n");
            //    Console.WriteLine("        회원 ID : " + uv.UserId);
            //    Console.WriteLine("        회원 비밀 번호 : " + uv.UserPassword);
            //    Console.WriteLine("        회원 이름 입력 : " + uv.UserName);
            //    Console.WriteLine($"        {uv.UserName} 나이 : " + uv.UserAge);
            //    Console.WriteLine($"        {uv.UserName} 핸드폰 번호 : " + uv.UserPhoneNumber);
            //    Console.WriteLine($"        {uv.UserName} 회원 주소 : " + uv.UserAddress);
            //    Console.WriteLine($"        {uv.UserName} 빌린 책 이름 : " + searchList[j].BookName);
            //    Console.WriteLine($"        {uv.UserName} 빌린 책 갯수 : " + borrowList.Count());
            //    Console.WriteLine("\r\n");
            //    userBorrow.Add(new UserVO(uv.UserId, uv.UserPassword, uv.UserName,uv.UserAge, uv.UserPhoneNumber, uv.UserAddress, uv.BorrowedBookList, borrowList.Count()));                        
            //}
            count1++;
            //foreach (UserVO uv in userBorrow)
            //{
            //    Console.WriteLine("       ------------------------------------------------------------------    ");
            //    Console.WriteLine("\r\n");
            //    Console.WriteLine("        회원 ID : " + uv.UserId);
            //    Console.WriteLine("        회원 비밀 번호 : " + uv.UserPassword);
            //    Console.WriteLine("        회원 이름 입력 : " + uv.UserName);
            //    Console.WriteLine($"        {uv.UserName} 나이 : " + uv.UserAge);
            //    Console.WriteLine($"        {uv.UserName} 핸드폰 번호 : " + uv.UserPhoneNumber);
            //    Console.WriteLine($"        {uv.UserName} 회원 주소 : " + uv.UserAddress);
            //    Console.WriteLine($"        {uv.UserName} 빌린 책 이름 : " + uv.BorrowedBookList);
            //    Console.WriteLine($"        {uv.UserName} 빌린 책 갯수 : " + uv.BorrowedBookCount);
            //    Console.WriteLine("\r\n");

            //}


            if (count1 == 0)
            {
                Console.Write("\r\n        대출 하시려는 책의 유효한 ID넘버를 입력하세요(ex.ID1234) : ");
            }
        }
        return borrowList;
    }

    public void returnBook(List<BookVO> testBookList, List<UserVO> loginUser, List<UserVO> userList, List<BookHistoryVO> bookHistoryList)
    {
        bool check = true;
        bool check1 = true;
        bool check2 = true;
        Console.Clear();
        Controller ct = new Controller();
        testBookList = Controller.testBookList(testBookList);
        userList = Controller.userList(userList);
        bookHistoryList = Controller.bookHistoryList(bookHistoryList);

        List<BookVO> searchList = new List<BookVO>();
        List<BookVO> borrowList = new List<BookVO>();
        List<UserVO> userBorrow = new List<UserVO>();
        int count = 0;
        ui.Get().printScreenEtc();
        while (check1)
            if (loginUser[0].BorrowedBookCount == 0)
            {
                Console.WriteLine("\r\n");
                Console.WriteLine("        {0}님의 대출 책 목록                                                 ", loginUser[0].UserName);
                Console.WriteLine("\r\n");
                Console.WriteLine("\r\n");
                Console.WriteLine("        반납할 책이 없습니다 ");
                check1 = false;
                Console.WriteLine("        뒤로가려면 ESC를 눌러주세요. ");
                string input1 = MenuControl.Get().ReadESC();
                if (input1 == "\0")
                {
                    check1 = false;
                    break;
                }

            }

            else
            {
                for (int i = 0; i < loginUser.Count; i++)
                {
                    for (int j = 0; j < userList.Count; j++)
                    {
                        if (userList[j].UserId == loginUser[i].UserId)
                        {
                            userBorrow.Add(userList[j]);
                        }
                    }
                }
                string[] split = userBorrow[0].BorrowedBookList.Split(' ');
                Console.WriteLine("\r\n");
                Console.WriteLine("        {0}님의 대출 책 목록                                                 ", loginUser[0].UserName);
                Console.WriteLine("\r\n");
                for (int n = 0; n < split.Length - 1; n++)
                {
                    Console.WriteLine($"        {count} {split[n]}                                            ");
                    count++;
                }
                Console.WriteLine("\r\n");
                Console.Write("        반납할 책의 숫자를 입력해주세요 : ");
                while (check)
                {
                    string input = MenuControl.Get().ReadNumber();
                    if (input == "\0")
                    {
                        check = false;
                        check1 = false;
                        break;
                    }
                    int num = int.Parse(input);
                    string userReturn = null;
                    for (int i = 0; i < loginUser.Count; i++)
                    {
                        for (int j = 0; j < userList.Count; j++)
                        {
                            if (userList[j].UserId == loginUser[i].UserId)
                            {
                                for (int k = 0; k < split.Length - 1; k++)
                                {
                                    if (k != num)
                                    {
                                        userReturn += split[k] + " ";
                                    }
                                }
                                userList[j].BorrowedBookList = userReturn;
                                userList[j].BorrowedBookCount--;
                                for (int d = 0; d< testBookList.Count; d++)
                                {
                                   if (testBookList[d].BookName == split[num])
                                    {
                                        testBookList[d].BookQuantity++;
                                    }
                                }                                
                                Controller controller = new Controller();
                                controller.UpdataUserData(userList);
                                //HistoryOfReturn(bookList, loginUser, bookHistory);                                
                                Console.Write($"\r\n        {split[num]}책이 반납되었습니다. ");
                                controller.HistoryOfReturn(split[num], loginUser[0].UserName, bookHistoryList);
                                controller.UpdateBookHistoryList(bookHistoryList);
                                string input1 = MenuControl.Get().ReadESC();
                                if (input1 == "\0")
                                {
                                    check = false;
                                    check1 = false;
                                    break;
                                }

                            }
                        }
                    }
                    break;
                }
            }
    }



}
