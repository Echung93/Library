using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class start 
{
    ui ui = new ui();
    public start() 
    {
        Controller ct = new Controller();
        UserRegister ur = new UserRegister();
        List<BookVO> bookList = new List<BookVO>();
        List<UserVO> userList = new List<UserVO>();
        bookList = Controller.bookList(bookList);
        userList = Controller.userList(userList);
        ui.mainMenu(userList);
        
    }
}
