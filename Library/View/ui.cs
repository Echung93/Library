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
                            //lo.loginUser(userList);
                            //printScreen1(bookList);
                            //books borrowBooks = new books()
                            loginUser = lo.loginUser(userList);
                            foreach (UserVO uv in loginUser)
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
                            ui.Get().printScreen1(bookList);
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
            bookList = Controller.bookList(bookList);
            userList = Controller.userList(userList);

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
                            borrowList = books.borrowBooks(bookList, loginUser);
                            foreach (UserVO uv in loginUser)
                            {
                                Console.WriteLine("       ------------------------------------------------------------------    ");
                                Console.WriteLine("\r\n");
                                Console.WriteLine("        회원 ID : " + uv.UserId);
                                Console.WriteLine("        회원 비밀 번호 : " + uv.UserPassword);
                                Console.WriteLine("        회원 이름 입력 : " + uv.UserName);
                                Console.WriteLine($"        {uv.UserName} 나이 : " + uv.UserAge);
                                Console.WriteLine($"        {uv.UserName} 핸드폰 번호 : " + uv.UserPhoneNumber);
                                Console.WriteLine($"        {uv.UserName} 회원 주소 : " + uv.UserAddress);
                                Console.WriteLine($"        {uv.UserName} 빌린 책 이름 : " + uv.BorrowedBookList);
                                Console.WriteLine($"        {uv.UserName} 빌린 책 갯수 : " + uv.BorrowedBookCount);
                                Console.WriteLine("\r\n");
                            }

                            break;
                        }

                    case "3":
                        {
                            break;
                        }

                    case "4":
                        {
                            break;
                        }

                    case "5":
                        {
                            break;
                        }

                    case "6":
                        {
                            break;
                        }

                    case "7":
                        {
                            break;
                        }

                    case "\0":
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("1~7번의 숫자를 입력해주세요.");
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
        Console.WriteLine("                             ▶    회 원 가 입    ◀                         ");
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
}
