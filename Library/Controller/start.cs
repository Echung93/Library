using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class start
{
    public start()
    {        
        Controller ct = new Controller();
        UserRegister ur = new UserRegister();
        List<BookVO> bookList = new List<BookVO>();
        List<UserVO> userList = new List<UserVO>();
        bookList = Controller.bookList(bookList);
        userList = Controller.userList(userList);

        ui.Get().mainMenu(userList);
    }
}
