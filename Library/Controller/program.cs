using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;

public class program
{ 
    static void Main(string[] args)
    {
        Books books = new Books();
        Controller ct = new Controller();
        UserRegister ur = new UserRegister();
        List<BookVO> bookList = new List<BookVO>();
        List<BookVO> borrowList = new List<BookVO>();
        List<UserVO> userList = new List<UserVO>();
        bookList = Controller.bookList(bookList);
        userList = Controller.userList(userList);
        start start = new start();
    }
}