using System;

public class MenuControl
{
    private static MenuControl instance = null;

    public static MenuControl Get()
    {
        if (instance == null)
            instance = new MenuControl();

        return instance;
    }
    public string ReadString()    //string 입력하는 메소드, 뒤로가기때문에
    {
        string readString = "";
        ConsoleKeyInfo key;
        while (true)
        {
            key = Console.ReadKey(true);

            if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Escape
                && IsKoreanString(key))
            {
                readString += key.KeyChar;
                Console.Write(key.KeyChar);
            }
            else if (key.Key == ConsoleKey.Backspace && readString.Length > 0)
            {
                int lastIndex = readString.Length - 1;
                if (readString[lastIndex] >= '가' && readString[lastIndex] <= '힣')       //한글일경우
                {
                    readString = readString.Substring(0, (readString.Length - 1));
                    Console.Write("\b\b  \b\b");
                }
                else
                {
                    readString = readString.Substring(0, (readString.Length - 1));  //한글 이외의 문자.
                    Console.Write("\b \b");
                }
            }
            else if (key.Key == ConsoleKey.Escape)      //esc 누를 경우 null 반환
            {
                return "\0";
            }
            else if (key.Key == ConsoleKey.Enter)       //엔터를 누를경우 저장된 스트링 반환
            {
                if (readString == "")
                    continue;
                return readString;
            }
        }
    }

    public string ReadNumber()    //숫자만 입력하는 메소드
    {
        string Number = "";
        ConsoleKeyInfo key;
        while (true)
        {
            key = Console.ReadKey(true);
            if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Escape
              && IsNumber(key))
            {
                Number += key.KeyChar;
                Console.Write(key.KeyChar);
            }
            else if (key.Key == ConsoleKey.Backspace && Number.Length > 0)
            {
                Number = Number.Substring(0, (Number.Length - 1));
                Console.Write("\b \b");
            }

            else if (key.Key == ConsoleKey.Escape)      //ESC이면 NULL 반환.
            {
                return "\0";
            }

            else if (key.Key == ConsoleKey.Enter)       //엔터누르면 값반환.
            {
                if (Number == "")
                    continue;
                return Number;
            }
        }
    }

    public string ReadESC()    //ESC만 입력하는 메소드
    {
        ConsoleKeyInfo key;
        while (true)
        {
            key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Escape)      //ESC이면 NULL 반환.
            {
                return "\0";
            }
        }
    }

    public bool IsNumber(ConsoleKeyInfo key)      //한글영어숫자만을 입력받기 위해인지 테스트
    {
        char trying = key.KeyChar;
        if (key == null) return false;
        if ((key.KeyChar >= '0' && key.KeyChar <= '9'))
            return true;
        return false;
    }

    public bool IsKoreanString(ConsoleKeyInfo key)      //한글영어숫자만을 입력받기 위해인지 테스트
    {
        char trying = key.KeyChar;
        if (key == null) return false;
        if ((key.KeyChar >= 'a' && key.KeyChar <= 'z') || (key.KeyChar >= 'A' && key.KeyChar <= 'Z') || (key.KeyChar >= '0' && key.KeyChar <= '9') ||
            (key.KeyChar >= '가' && key.KeyChar <= '힣') || key.KeyChar == ' ')
            return true;
        return false;
    }

    public string ReadPassword()
    {
        string password = "";
        ConsoleKeyInfo key;
        while (true)
        {
            key = Console.ReadKey(true);

            if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Escape
                && IsKoreanString(key))
            {
                password += key.KeyChar;
                Console.Write("*");
            }
            else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
            {
                int lastIndex = password.Length - 1;
                if (password[lastIndex] >= '가' && password[lastIndex] <= '힣')       //한글일경우
                {
                    password = password.Substring(0, (password.Length - 1));
                    Console.Write("\b\b  \b\b");
                }
                else
                {
                    password = password.Substring(0, (password.Length - 1));  //한글 이외의 문자.
                    Console.Write("\b \b");
                }
            }
            else if (key.Key == ConsoleKey.Escape)      //esc 누를 경우 null 반환
            {
                return "\0";
            }
            else if (key.Key == ConsoleKey.Enter)       //엔터를 누를경우 저장된 스트링 반환
            {
                if (password == "")
                    continue;
                return password;
            }
        }
    }
}
        
