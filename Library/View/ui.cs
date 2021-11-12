using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ui
{
    private static ui instance = null;

    public static ui Get()
    {
        if (instance == null)
            instance = new ui();

        return instance;
    }

    List<UserVO> loginUser = new List<UserVO>();
    public void mainMenu(List<UserVO> userList)
    {


        bool check = true;
        bool check1 = true;
        while (check)
        {
            Console.Clear();
            check1 = true;

            Login lo = new Login();
            List<BookVO> bookList = new List<BookVO>();
            List<BookVO> searchList = new List<BookVO>();
            List<BookHistoryVO> bookHistories = new List<BookHistoryVO>();
            Console.WriteLine("       ------------------------------------------------------------------    ");
            Console.WriteLine("\r\n");
            Console.WriteLine("          ■        ■   ■■■     ■■■     ■■   ■■■   ■    ■      ");
            Console.WriteLine("          ■        ■   ■   ■    ■   ■   ■  ■  ■   ■   ■  ■       ");
            Console.WriteLine("          ■        ■   ■■■■   ■■■    ■■■  ■■■      ■         ");
            Console.WriteLine("          ■        ■   ■    ■   ■   ■   ■  ■  ■   ■     ■         ");
            Console.WriteLine("          ■■■■  ■   ■■■■   ■    ■  ■  ■  ■    ■    ■         ");
            Console.WriteLine("\r\n");
            Console.WriteLine("       ---------------------------------------------- 뒤로가기 : ESC ----    ");
            Console.WriteLine("\r\n");
            Console.WriteLine("\r\n");
            Console.WriteLine("                             ▶      로 그 인     ◀                         ");
            Console.WriteLine("\r\n");
            Console.WriteLine("                             ▶    회 원 가 입    ◀                         ");
            Console.WriteLine("\r\n");
            Console.WriteLine("                             ▶    관리자  모드   ◀                         ");
            Console.WriteLine("\r\n");
            Console.WriteLine("                             ▶       종  료      ◀                         ");
            Console.WriteLine("\r\n");
            Console.WriteLine("\r\n");
            Console.Write("                  원하시는 메뉴의 숫자(1~4)를 입력해주세요. : ");
            while (check1)
            {
                string input = MenuControl.Get().ReadNumber();
                switch (input)
                {
                    case "1":
                        {

                            loginUser = lo.loginUser(userList);
                            if (loginUser.Count != 0)
                            {
                                ui.Get().printScreen1(bookList);
                                check1 = false;
                                break;
                            }
                            check1 = false;
                            break;
                        }

                    case "2":
                        {
                            new Main();
                            check1 = false;
                            break;
                        }

                    case "3":
                        {
                            ui.Get().managerPage();
                            ui.Get().printScreen2(bookList, userList, bookHistories);
                            check1 = false;
                            break;
                        }

                    case "4":
                        {
                            check = false;
                            check1 = false;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("\r\n");
                            Console.Write("                  1~4번의 숫자를 입력해주세요.");
                            break;
                        }
                }

            }
        }
    }
    public void printScreen1(List<BookVO> bookList)
    {
        bool check = true;
        while (check)
        {
            bool check1 = true;
            Books books = new Books();
            Controller ct = new Controller();
            UserRegister ur = new UserRegister();
            bookList = new List<BookVO>();
            List<BookVO> searchList = new List<BookVO>();
            List<BookVO> borrowList = new List<BookVO>();
            List<UserVO> userList = new List<UserVO>();
            List<BookHistoryVO> bookHistoryList = new List<BookHistoryVO>();
            bookList = Controller.bookList(bookList);
            userList = Controller.userList(userList);
            bookHistoryList = Controller.bookHistoryList(bookHistoryList);

            Console.WriteLine("       ------------------------------------------------------------------    ");
            Console.WriteLine("\r\n");
            Console.WriteLine("          ■        ■   ■■■     ■■■     ■■   ■■■   ■    ■      ");
            Console.WriteLine("          ■        ■   ■   ■    ■   ■   ■  ■  ■   ■   ■  ■       ");
            Console.WriteLine("          ■        ■   ■■■■   ■■■    ■■■  ■■■      ■         ");
            Console.WriteLine("          ■        ■   ■    ■   ■   ■   ■  ■  ■   ■     ■         ");
            Console.WriteLine("          ■■■■  ■   ■■■■   ■    ■  ■  ■  ■    ■    ■         ");
            Console.WriteLine("\r\n");
            Console.WriteLine("       ---------------------------------------------- 뒤로가기 : ESC ----    ");
            Console.WriteLine("\r\n");
            Console.WriteLine("\r\n");
            Console.WriteLine("                             ▶      책  검색     ◀                         ");
            Console.WriteLine("\r\n");
            Console.WriteLine("                             ▶      책  대출     ◀                         ");
            Console.WriteLine("\r\n");
            Console.WriteLine("                             ▶      책  반납     ◀                         ");
            Console.WriteLine("\r\n");
            Console.WriteLine("                             ▶     책  리스트    ◀                         ");
            Console.WriteLine("\r\n");
            Console.WriteLine("                             ▶   나의 회원 정보  ◀                         ");
            Console.WriteLine("\r\n");
            Console.WriteLine("                             ▶ 처음 메뉴로  가기 ◀                         ");
            Console.WriteLine("\r\n");
            Console.WriteLine("                             ▶       종  료      ◀                         ");
            Console.WriteLine("\r\n");
            Console.WriteLine("\r\n");
            Console.Write("                  원하시는 메뉴의 숫자(1~7)를 입력해주세요. : ");

            while (check1)
            {
                string input = MenuControl.Get().ReadString();

                if (input == "\0")
                {
                    check = false;
                    check1 = false;
                    break;
                }
                switch (input)
                {
                    case "1":
                        {
                            new Books().searchBook(bookList);
                            check1 = false;
                            break;
                        }

                    case "2":
                        {
                            check1 = false;
                            borrowList = books.borrowBooks(bookList, loginUser, userList, bookHistoryList);
                            //for (int i = 0; i < loginUser.Count; i++)
                            //{
                            //    for (int j = 0; j < userList.Count; j++)
                            //    {
                            //        if (loginUser[i].UserId == userList[j].UserId)
                            //        {
                            //            Console.WriteLine("       ------------------------------------------------------------------    ");
                            //            Console.WriteLine("\r\n");
                            //            Console.WriteLine("        회원 ID : " + userList[j].UserId);
                            //            Console.WriteLine("        회원 비밀 번호 : " + userList[j].UserPassword);
                            //            Console.WriteLine("        회원 이름 입력 : " + userList[j].UserName);
                            //            Console.WriteLine($"        {userList[j].UserName} 나이 : " + userList[j].UserAge);
                            //            Console.WriteLine($"        {userList[j].UserName} 핸드폰 번호 : " + userList[j].UserPhoneNumber);
                            //            Console.WriteLine($"        {userList[j].UserName} 회원 주소 : " + userList[j].UserAddress);
                            //            Console.WriteLine($"        {userList[j].UserName} 빌린 책 이름 : " + userList[j].BorrowedBookList);
                            //            Console.WriteLine($"        {userList[j].UserName} 빌린 책 갯수 : " + userList[j].BorrowedBookCount);
                            //            Console.WriteLine("\r\n");

                            //        }
                            //    }

                            //}

                            if (input == "\0")
                            {
                                break;
                            }
                            MenuControl.Get().ReadESC();
                            check = true;
                            check1 = false;
                            break;
                        }

                    case "3":
                        {
                            new Books().returnBook(bookList, loginUser, userList, bookHistoryList);
                            break;
                        }

                    case "4":
                        {
                            Console.Clear();
                            Controller.bookList(bookList);
                            for (int i = 0; i < bookList.Count; i++)
                            {
                                Console.WriteLine("       ------------------------------------------------------------------    ");
                                Console.WriteLine("\r\n");
                                Console.WriteLine("        책  ID 넘버 : " + bookList[i].BookIDNumber);
                                Console.WriteLine("        책  이름 : " + bookList[i].BookName);
                                Console.WriteLine("        책  저자 : " + bookList[i].BookAuthor);
                                Console.WriteLine("        책  출판사 : " + bookList[i].BookPublisher);
                                Console.WriteLine("        책  가격 : " + bookList[i].BookPrice);
                                Console.WriteLine("        책  수량 : " + bookList[i].BookQuantity);
                            }

                            Console.WriteLine("\r\n        뒤로가기를 원하시면 ESC를 눌러주세요.");
                            MenuControl.Get().ReadESC();
                            if (input == "\0")
                            {
                                break;
                            }
                            check = true;
                            check1 = false;
                            break;
                        }

                    case "5":
                        {
                            Console.Clear();
                            for (int j = 0; j < userList.Count; j++)
                            {
                                if (userList[j].UserId == loginUser[0].UserId)
                                {
                                    Console.WriteLine("       ------------------------------------------------------------------    ");
                                    Console.WriteLine("\r\n");
                                    Console.WriteLine("        회원 ID : " + userList[j].UserId);
                                    Console.WriteLine("        회원 이름 : " + userList[j].UserName);
                                    Console.WriteLine("        회원 나이 : " + userList[j].UserAge);
                                    Console.WriteLine("        회원 핸드폰 번호 : " + userList[j].UserPhoneNumber);
                                    Console.WriteLine("        회원 주소 : " + userList[j].UserAddress);
                                    Console.WriteLine("        빌린 책 갯수 : " + userList[j].BorrowedBookCount);
                                    Console.WriteLine("        빌린 책 이름 : " + userList[j].BorrowedBookList);
                                    Console.WriteLine("\r\n");

                                    Console.Write("        전화번호를 수정하려면 1번,주소를 수정하려면 2번 입력해주세요. : ");
                                    string input0 = MenuControl.Get().ReadString();
                                    if (input0 == "\0")
                                    {
                                        check = true;
                                        check1 = false;
                                        break;
                                    }

                                    else if (input0 == "1")
                                    {
                                        
                                        Console.Write("\r\n        수정하려는 전화번호를 입력('-' 제외하고 입력) : ");
                                        string input1 = MenuControl.Get().ReadNumber();
                                        userList[j].UserPhoneNumber = input1;
                                        Controller controller = new Controller();
                                        controller.UpdataUserData(userList);
                                        break;
                                    }

                                    else if (input0 == "2")
                                    {
                                        
                                        Console.Write("\r\n        수정하려는 주소를 입력 : ");
                                        string input2 = MenuControl.Get().ReadString();
                                        userList[j].UserAddress = input2;
                                        Controller controller = new Controller();
                                        controller.UpdataUserData(userList);
                                        break;
                                    }
                                }

                            }
                            check = true;
                            check1 = false;
                            break;
                        }

                    case "6":
                        {
                            check = false;
                            check1 = false;
                            break;
                        }

                    case "7":
                        {
                            Environment.Exit(7);
                            break;
                        }

                    case "\0":
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\r\n                  1~7번의 숫자를 입력해주세요.");
                            break;
                        }
                }
            }
        }
    }
    public void printScreen1_1()
    {

        Console.WriteLine("       ------------------------------------------------------------------    ");
        Console.WriteLine("\r\n");
        Console.WriteLine("          ■        ■   ■■■     ■■■     ■■   ■■■   ■    ■      ");
        Console.WriteLine("          ■        ■   ■   ■    ■   ■   ■  ■  ■   ■   ■  ■       ");
        Console.WriteLine("          ■        ■   ■■■■   ■■■    ■■■  ■■■      ■         ");
        Console.WriteLine("          ■        ■   ■    ■   ■   ■   ■  ■  ■   ■     ■         ");
        Console.WriteLine("          ■■■■  ■   ■■■■   ■    ■  ■  ■  ■    ■    ■         ");
        Console.WriteLine("\r\n");
        Console.WriteLine("       ---------------------------------------------- 뒤로가기 : ESC ----    ");
        Console.WriteLine("\r\n");
        Console.WriteLine("       ------------------------   책 검색 메뉴   ------------------------    ");
        Console.WriteLine("\r\n");
        Console.WriteLine("                             ▶ 책  이름으로 검색 ◀                         ");
        Console.WriteLine("\r\n");
        Console.WriteLine("                             ▶ 책  저자명로 검색 ◀                         ");
        Console.WriteLine("\r\n");
        Console.WriteLine("                             ▶ 책  출판사로 검색 ◀                         ");
        Console.WriteLine("\r\n");
        Console.WriteLine("                             ▶ 메뉴로  돌아 가기 ◀                         ");
        Console.WriteLine("\r\n");
        Console.WriteLine("\r\n");
        Console.Write("                  원하시는 메뉴의 숫자(1~4)를 입력해주세요. : ");

    }

    public void printScreen1_1_1()
    {
        Console.WriteLine("       ------------------------------------------------------------------    ");
        Console.WriteLine("\r\n");
        Console.WriteLine("          ■        ■   ■■■     ■■■     ■■   ■■■   ■    ■      ");
        Console.WriteLine("          ■        ■   ■   ■    ■   ■   ■  ■  ■   ■   ■  ■       ");
        Console.WriteLine("          ■        ■   ■■■■   ■■■    ■■■  ■■■      ■         ");
        Console.WriteLine("          ■        ■   ■    ■   ■   ■   ■  ■  ■   ■     ■         ");
        Console.WriteLine("          ■■■■  ■   ■■■■   ■    ■  ■  ■  ■    ■    ■         ");
        Console.WriteLine("\r\n");
        Console.WriteLine("       ---------------------------------------------- 뒤로가기 : ESC ----    ");
        Console.WriteLine("\r\n");
        Console.WriteLine("\r\n");
        Console.Write("        검색하실/대여하실 책의 이름 정보 검색 : ");
    }

    public void printScreen1_1_2()
    {
        Console.WriteLine("       ------------------------------------------------------------------    ");
        Console.WriteLine("\r\n");
        Console.WriteLine("          ■        ■   ■■■     ■■■     ■■   ■■■   ■    ■      ");
        Console.WriteLine("          ■        ■   ■   ■    ■   ■   ■  ■  ■   ■   ■  ■       ");
        Console.WriteLine("          ■        ■   ■■■■   ■■■    ■■■  ■■■      ■         ");
        Console.WriteLine("          ■        ■   ■    ■   ■   ■   ■  ■  ■   ■     ■         ");
        Console.WriteLine("          ■■■■  ■   ■■■■   ■    ■  ■  ■  ■    ■    ■         ");
        Console.WriteLine("\r\n");
        Console.WriteLine("       ---------------------------------------------- 뒤로가기 : ESC ----    ");
        Console.WriteLine("\r\n");
        Console.WriteLine("\r\n");
        Console.Write("        검색하실 책의 저자 이름 정보 검색 : ");
    }

    public void printScreen1_1_3()
    {
        Console.WriteLine("       ------------------------------------------------------------------    ");
        Console.WriteLine("\r\n");
        Console.WriteLine("          ■        ■   ■■■     ■■■     ■■   ■■■   ■    ■      ");
        Console.WriteLine("          ■        ■   ■   ■    ■   ■   ■  ■  ■   ■   ■  ■       ");
        Console.WriteLine("          ■        ■   ■■■■   ■■■    ■■■  ■■■      ■         ");
        Console.WriteLine("          ■        ■   ■    ■   ■   ■   ■  ■  ■   ■     ■         ");
        Console.WriteLine("          ■■■■  ■   ■■■■   ■    ■  ■  ■  ■    ■    ■         ");
        Console.WriteLine("\r\n");
        Console.WriteLine("       ---------------------------------------------- 뒤로가기 : ESC ----    ");
        Console.WriteLine("\r\n");
        Console.WriteLine("\r\n");
        Console.Write("        검색하실 책의 출판사 이름 정보 검색 : ");
    }

    public void printScreen1_2()
    {
        Console.WriteLine("       ------------------------------------------------------------------    ");
        Console.WriteLine("\r\n");
        Console.WriteLine("          ■        ■   ■■■     ■■■     ■■   ■■■   ■    ■      ");
        Console.WriteLine("          ■        ■   ■   ■    ■   ■   ■  ■  ■   ■   ■  ■       ");
        Console.WriteLine("          ■        ■   ■■■■   ■■■    ■■■  ■■■      ■         ");
        Console.WriteLine("          ■        ■   ■    ■   ■   ■   ■  ■  ■   ■     ■         ");
        Console.WriteLine("          ■■■■  ■   ■■■■   ■    ■  ■  ■  ■    ■    ■         ");
        Console.WriteLine("\r\n");
        Console.WriteLine("       ---------------------------------------------- 뒤로가기 : ESC ----    ");
        Console.WriteLine("\r\n");
        Console.WriteLine("\r\n");
        Console.Write("        검색하실/대여하실 책의 이름 정보 검색 :                                  ");
    }

    public void printScreen1_3()
    {
        Console.WriteLine("       ------------------------------------------------------------------    ");
        Console.WriteLine("\r\n");
        Console.WriteLine("          ■        ■   ■■■     ■■■     ■■   ■■■   ■    ■      ");
        Console.WriteLine("          ■        ■   ■   ■    ■   ■   ■  ■  ■   ■   ■  ■       ");
        Console.WriteLine("          ■        ■   ■■■■   ■■■    ■■■  ■■■      ■         ");
        Console.WriteLine("          ■        ■   ■    ■   ■   ■   ■  ■  ■   ■     ■         ");
        Console.WriteLine("          ■■■■  ■   ■■■■   ■    ■  ■  ■  ■    ■    ■         ");
        Console.WriteLine("\r\n");
        Console.WriteLine("       ---------------------------------------------- 뒤로가기 : ESC ----    ");
        Console.WriteLine("\r\n");
        Console.WriteLine("\r\n");
        Console.WriteLine("        {0}님의 대출 책 목록                                                 ");
        Console.WriteLine("\r\n");
        Console.WriteLine("                                                      ");
        Console.WriteLine("\r\n");
        Console.Write("        반납할 책의 숫자를 입력해주세요 :                         ");

    }

    public void printScreen1_4()
    {
        Console.WriteLine("       ------------------------------------------------------------------    ");
        Console.WriteLine("\r\n");
        Console.WriteLine("          ■        ■   ■■■     ■■■     ■■   ■■■   ■    ■      ");
        Console.WriteLine("          ■        ■   ■   ■    ■   ■   ■  ■  ■   ■   ■  ■       ");
        Console.WriteLine("          ■        ■   ■■■■   ■■■    ■■■  ■■■      ■         ");
        Console.WriteLine("          ■        ■   ■    ■   ■   ■   ■  ■  ■   ■     ■         ");
        Console.WriteLine("          ■■■■  ■   ■■■■   ■    ■  ■  ■  ■    ■    ■         ");
        Console.WriteLine("\r\n");
        Console.WriteLine("       ---------------------------------------------- 뒤로가기 : ESC ----    ");
        Console.WriteLine("\r\n");
        Console.WriteLine("\r\n");
        Console.WriteLine("                                  등록 책 LIST                               ");
        Console.WriteLine("\r\n");


    }

    public void printScreen1_5()
    {
        Console.WriteLine("       ------------------------------------------------------------------    ");
        Console.WriteLine("\r\n");
        Console.WriteLine("          ■        ■   ■■■     ■■■     ■■   ■■■   ■    ■      ");
        Console.WriteLine("          ■        ■   ■   ■    ■   ■   ■  ■  ■   ■   ■  ■       ");
        Console.WriteLine("          ■        ■   ■■■■   ■■■    ■■■  ■■■      ■         ");
        Console.WriteLine("          ■        ■   ■    ■   ■   ■   ■  ■  ■   ■     ■         ");
        Console.WriteLine("          ■■■■  ■   ■■■■   ■    ■  ■  ■  ■    ■    ■         ");
        Console.WriteLine("\r\n");
        Console.WriteLine("       ---------------------------------------------- 뒤로가기 : ESC ----    ");
        Console.WriteLine("\r\n");
        Console.WriteLine("\r\n");
        Console.WriteLine("                                  등록 책 LIST                               ");



    }

    public void printScreenEtc()
    {
        Console.WriteLine("       ------------------------------------------------------------------    ");
        Console.WriteLine("\r\n");
        Console.WriteLine("          ■        ■   ■■■     ■■■     ■■   ■■■   ■    ■      ");
        Console.WriteLine("          ■        ■   ■   ■    ■   ■   ■  ■  ■   ■   ■  ■       ");
        Console.WriteLine("          ■        ■   ■■■■   ■■■    ■■■  ■■■      ■         ");
        Console.WriteLine("          ■        ■   ■    ■   ■   ■   ■  ■  ■   ■     ■         ");
        Console.WriteLine("          ■■■■  ■   ■■■■   ■    ■  ■  ■  ■    ■    ■         ");
        Console.WriteLine("\r\n");
        Console.WriteLine("       ---------------------------------------------- 뒤로가기 : ESC ----    ");
        Console.WriteLine("\r\n");
        Console.WriteLine("\r\n");
    }

    public void managerPage()
    {
        Console.Clear();
        Console.WriteLine("       ------------------------------------------------------------------    ");
        Console.WriteLine("\r\n");
        Console.WriteLine("          ■        ■   ■■■     ■■■     ■■   ■■■   ■    ■      ");
        Console.WriteLine("          ■        ■   ■   ■    ■   ■   ■  ■  ■   ■   ■  ■       ");
        Console.WriteLine("          ■        ■   ■■■■   ■■■    ■■■  ■■■      ■         ");
        Console.WriteLine("          ■        ■   ■    ■   ■   ■   ■  ■  ■   ■     ■         ");
        Console.WriteLine("          ■■■■  ■   ■■■■   ■    ■  ■  ■  ■    ■    ■         ");
        Console.WriteLine("\r\n");
        Console.WriteLine("       ---------------------------------------------- 뒤로가기 : ESC ----    ");
        Console.WriteLine("\r\n");
        Console.WriteLine("\r\n");
        Console.Write("         관리자 비밀 번호를 입력 하시오 : ");
        string input = MenuControl.Get().ReadPassword();

        if (input == "\0")
        {
        }
        else
        {
            new Login().loginManager(input);
        }

    }
    public void printScreen2(List<BookVO> bookList, List<UserVO> userList, List<BookHistoryVO> bookHistories)
    {
        Console.Clear();
        bool check = true;
        while (check)
        {
            bool check1 = true;
            Books books = new Books();
            Controller ct = new Controller();
            UserRegister ur = new UserRegister();
            bookList = new List<BookVO>();
            List<BookVO> searchList = new List<BookVO>();
            List<BookVO> borrowList = new List<BookVO>();
            bookList = Controller.bookList(bookList);
            userList = Controller.userList(userList);
            bookHistories = Controller.bookHistoryList(bookHistories);

            Console.WriteLine("       ------------------------------------------------------------------    ");
            Console.WriteLine("\r\n");
            Console.WriteLine("          ■        ■   ■■■     ■■■     ■■   ■■■   ■    ■      ");
            Console.WriteLine("          ■        ■   ■   ■    ■   ■   ■  ■  ■   ■   ■  ■       ");
            Console.WriteLine("          ■        ■   ■■■■   ■■■    ■■■  ■■■      ■         ");
            Console.WriteLine("          ■        ■   ■    ■   ■   ■   ■  ■  ■   ■     ■         ");
            Console.WriteLine("          ■■■■  ■   ■■■■   ■    ■  ■  ■  ■    ■    ■         ");
            Console.WriteLine("\r\n");
            Console.WriteLine("       ---------------------------------------------- 뒤로가기 : ESC ----    ");
            Console.WriteLine("\r\n");
            Console.WriteLine("\r\n");
            Console.WriteLine("       ------------------------    관리자 메뉴    -----------------------");
            Console.WriteLine("\r\n");
            Console.WriteLine("\r\n");
            Console.WriteLine("                             ▶    회원  리스트   ◀                         ");
            Console.WriteLine("\r\n");
            Console.WriteLine("                             ▶     책  리스트    ◀                         ");
            Console.WriteLine("\r\n");
            Console.WriteLine("                             ▶     회원  검색    ◀                         ");
            Console.WriteLine("\r\n");
            Console.WriteLine("                             ▶     회원  삭제    ◀                         ");
            Console.WriteLine("\r\n");
            Console.WriteLine("                             ▶   책  정보 수정   ◀                         ");
            Console.WriteLine("\r\n");
            Console.WriteLine("                             ▶   신규 책  등록   ◀                         ");
            Console.WriteLine("\r\n");
            Console.WriteLine("                             ▶      책  삭제     ◀                         ");
            Console.WriteLine("\r\n");
            Console.WriteLine("                             ▶ 책 대여/반납 기록 ◀                         ");
            Console.WriteLine("\r\n");
            Console.WriteLine("                             ▶ 메뉴로  돌아 가기 ◀                         ");
            Console.WriteLine("\r\n");
            Console.WriteLine("\r\n");
            Console.Write("                  원하시는 메뉴의 숫자(1~9)를 입력해주세요. : ");
            while (check1)
            {
                string input = MenuControl.Get().ReadString();

                if (input == "\0")
                {
                    check = false;
                    check1 = false;
                    break;
                }
                switch (input)
                {
                    case "1":
                        {
                            Console.Clear();
                            foreach (UserVO uv in userList)
                            {
                                Console.WriteLine("       ------------------------------------------------------------------    ");
                                Console.WriteLine("\r\n");
                                Console.WriteLine("        회원 이름 : " + uv.UserName);
                                Console.WriteLine("        회원 나이 : " + uv.UserAge);
                                Console.WriteLine("        회원 휴대폰 번호 : " + uv.UserPhoneNumber);
                                Console.WriteLine("        회원 주소 : " + uv.UserAddress);
                                Console.WriteLine("        대출한 권 수 : " + uv.BorrowedBookCount);
                                Console.WriteLine("\r\n");
                            }
                            Console.WriteLine("       ------------------------------------------------------------------    ");
                            Console.WriteLine($"                등록된 총 회원 수는 : {userList.Count} 명 입니다");
                            Console.WriteLine("\r\n        뒤로가기를 원하시면 ESC를 눌러주세요.");
                            string num = MenuControl.Get().ReadESC();

                            if (num == "\0")
                            {
                                check1 = false;
                                check = true;
                            }
                            break;

                        }

                    case "2":
                        {
                            Console.Clear();
                            foreach (BookVO bv in bookList)
                            {
                                Console.WriteLine("       ------------------------------------------------------------------    ");
                                Console.WriteLine("\r\n");
                                Console.WriteLine("        책  ID 넘버 : " + bv.BookIDNumber);
                                Console.WriteLine("        책  이름 : " + bv.BookName);
                                Console.WriteLine("        책  출판사 : " + bv.BookPublisher);
                                Console.WriteLine("        책  가격 : " + bv.BookPrice);
                                Console.WriteLine("        책  수량 : " + bv.BookQuantity);
                                Console.WriteLine("\r\n");
                            }
                            Console.WriteLine("       ------------------------------------------------------------------    ");
                            Console.WriteLine($"                등록된 총 책의 권 수는 : {bookList.Count} 개 입니다");
                            Console.WriteLine("\r\n        뒤로가기를 원하시면 ESC를 눌러주세요.");
                            string num = MenuControl.Get().ReadESC();

                            if (num == "\0")
                            {
                                check1 = false;
                                check = true;
                            }
                            break;
                        }

                    case "3":
                        {
                            bool check3 = true;

                            Console.Clear();
                            ui.Get().printScreenEtc();
                            int count = 0;
                            Console.Write("\r\n        검색하려는 회원의 이름이 무엇인가요?? : ");
                            while (check3)
                            {
                                input = MenuControl.Get().ReadString();
                                for (int i = 0; i < userList.Count; i++)
                                {
                                    if (userList[i].UserName == input)
                                    {
                                        Console.WriteLine("\r\n        회원 이름 : " + userList[i].UserName);
                                        Console.WriteLine("        회원 나이 : " + userList[i].UserAge);
                                        Console.WriteLine("        회원 휴대폰 번호 : " + userList[i].UserPhoneNumber);
                                        Console.WriteLine("        회원 주소 : " + userList[i].UserAddress);
                                        count++;
                                        check3 = false;
                                    }
                                }

                                if (input == "\0")
                                {
                                    check1 = false;
                                    check = true;
                                    check3 = false;
                                }

                                if (count == 0)
                                {
                                    Console.Write("\r\n        검색하시려는 회원의 이름을 정확히 입력하세요: ");
                                }
                            }
                            break;
                        }


                    case "4":
                        {
                            bool check3 = true;

                            Console.Clear();
                            ui.Get().printScreenEtc();
                            int count = 0;
                            Console.Write("\r\n        삭제하시려는 회원의 이름이 무엇인가요? : ");
                            while (check3)
                            {
                                input = MenuControl.Get().ReadString();
                                for (int i = 0; i < userList.Count; i++)
                                {
                                    if (userList[i].UserName == input && userList[i].BorrowedBookCount == 0)
                                    {
                                        userList.RemoveAt(i);
                                        count++;
                                        Console.Write("\r\n        삭제 완료 ");
                                        ct.UpdataUserData(userList);
                                        check3 = false;
                                    }

                                    else if (userList[i].UserName == input && userList[i].BorrowedBookCount != 0)
                                    {
                                        Console.Write("\r\n        해당 회원은 대출중인 책이 있어 삭제하지 못합니다. ");
                                    }
                                }

                                if (input == "\0")
                                {
                                    check1 = false;
                                    check = true;
                                    check3 = false;
                                }

                                if (count == 0)
                                {
                                    Console.Write("\r\n        삭제하시려는 회원의 이름을 정확히 입력하세요: ");
                                }
                            }
                            break;
                        }

                    case "5":
                        {
                            bool check3 = true;

                            Console.Clear();
                            ui.Get().printScreenEtc();
                            int count = 0;
                            Console.Write("\r\n        수량을 수정하고자 하는 책의 이름(띄어쓰기 상관 없이 입력) : ");
                            while (check3)
                            {
                                input = MenuControl.Get().ReadString();
                                for (int i = 0; i < bookList.Count; i++)
                                {
                                    if (bookList[i].BookName == input)
                                    {
                                        Console.Write($"\r\n        책 {bookList[i].BookName} 수정된 수량 입력 : ");
                                        string quantity = MenuControl.Get().ReadNumber();
                                        int BookQuantity = int.Parse(quantity);
                                        bookList[i].BookQuantity = BookQuantity;
                                        ct.UpdataBookData(bookList);
                                        Console.Write($"\r\n        책 정보 변경 완료! ");
                                        Console.WriteLine("\r\n        뒤로가기를 원하시면 ESC를 눌러주세요.");
                                        ct.UpdataBookData(bookList);
                                        count++;
                                        if (input == "\0")
                                        {
                                            check1 = false;
                                            check3 = false;
                                            check = true;
                                        }
                                    }
                                }

                                if (input == "\0")
                                {
                                    check1 = false;
                                    check = true;
                                    check3 = false;
                                }

                                if (count == 0)
                                {
                                    Console.Write("\r\n        수정하시려는 책의 이름을 정확히 입력하세요: ");
                                }
                            }
                            break;
                        }

                    case "6":
                        {
                            bool check3 = true;
                            while (check3)
                            {
                                Console.Clear();
                                ui.Get().printScreenEtc();
                                Console.Write("\r\n        책 ID 숫자 입력(입력예시 : ID1234) : ");
                                string BookIDNumber = MenuControl.Get().ReadString();
                                for (int i = 0; i < bookList.Count; i++)
                                {
                                    if (input == "\0")
                                    {
                                        check3 = false;
                                        break;
                                    }

                                    else if (bookList[i].BookIDNumber == BookIDNumber)
                                    {
                                        Console.Write("\r\n        있는 책 ID입니다. 다시 책 ID 숫자를 입력(입력예시 : ID1234) : ");
                                        BookIDNumber = Console.ReadLine();
                                    }

                                }
                                Console.Write("\r\n        책 이름 입력 : ");
                                string BookName = MenuControl.Get().ReadString();
                                for (int j = 0; j < bookList.Count; j++)
                                {
                                    if (input == "\0")
                                    {
                                        check3 = false;
                                        break;
                                    }

                                    else if (bookList[j].BookName == BookName)
                                    {
                                        Console.Write("\r\n        있는 책입니다. 다시 책 이름을 입력 : ");
                                        BookIDNumber = Console.ReadLine();
                                    }

                                }
                                Console.Write("\r\n        책 저자 입력 : ");
                                string BookAuthor = Console.ReadLine();
                                Console.Write("\r\n        책 출판사 입력 : ");
                                string BookPublisher = Console.ReadLine();
                                Console.Write("\r\n        책 가격 입력 : ");
                                string BookPrice = MenuControl.Get().ReadNumber();
                                Console.Write("\r\n        책 수량 입력 :  ");
                                string quantity = MenuControl.Get().ReadNumber();
                                int BookQuantity = int.Parse(quantity);
                                bookList.Add(new BookVO(BookIDNumber, BookName, BookPublisher, BookAuthor, BookPrice, BookQuantity));
                                Console.WriteLine($"{BookName} 책 등록 완료!");
                                Console.WriteLine("\r\n        뒤로가기를 원하시면 ESC를 눌러주세요.");
                                ct.UpdataBookData(bookList);
                                if (input == "\0")
                                {
                                    check1 = false;
                                    check = true;
                                }
                            }
                        }
                        break;

                    case "7":
                        {
                            bool check3 = true;

                            Console.Clear();
                            ui.Get().printScreenEtc();
                            int count = 0;
                            Console.Write("\r\n        삭제하시려는 책의 이름이 무엇인가요? : ");
                            while (check3)
                            {
                                input = MenuControl.Get().ReadString();
                                for (int i = 0; i < bookList.Count; i++)
                                {
                                    if (bookList[i].BookName == input)
                                    {
                                        bookList.RemoveAt(i);
                                        count++;
                                        Console.Write("\r\n        삭제 완료 ");
                                        ct.UpdataBookData(bookList);
                                        check3 = false;
                                    }
                                }

                                if (input == "\0")
                                {
                                    check1 = false;
                                    check = true;
                                    check3 = false;
                                }

                                if (count == 0)
                                {
                                    Console.Write("\r\n        삭제하시려는 책의 이름을 정확히 입력하세요: ");
                                }
                            }
                            break;
                        }

                    case "8":
                        {

                            Console.Clear();
                            ui.Get().printScreenEtc();
                            Console.WriteLine("               책 대출/반납 기록    ");
                            Console.WriteLine("\r\n");
                            Console.WriteLine("       ------------------------------------------------------------------    ");
                            foreach (BookHistoryVO bhv in bookHistories)
                            {

                                if (bhv.BorrowTime != null)
                                {
                                    Console.WriteLine("\r\n");
                                    Console.WriteLine($"        {bhv.UserName} 님께서 책 {bhv.BookName} 을{bhv.BorrowTime} 에 대출하셨습니다. ");
                                }

                                if ((bhv.ReturnTime != null))
                                {
                                    Console.WriteLine("\r\n");
                                    Console.WriteLine($"        {bhv.UserName} 님께서 책 {bhv.BookName} 을{bhv.ReturnTime} 에 반납하셨습니다. ");
                                }




                            }
                            Console.WriteLine("\r\n");
                            Console.WriteLine("       ------------------------------------------------------------------    ");
                            Console.WriteLine("\r\n        뒤로가기를 원하시면 ESC를 눌러주세요.");
                            string num = MenuControl.Get().ReadESC();

                            if (num == "\0")
                            {
                                check1 = false;
                                check = true;
                            }
                            break;

                        }

                    case "9":
                        {
                            check = false;
                            check1 = false;
                            break;
                        }
                    case "\0":
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\r\n                  1~9번의 숫자를 입력해주세요.");
                            break;
                        }
                }
            }
        }
    }
}
