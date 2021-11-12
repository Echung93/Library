using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class start
{
    public start()
    {        
        List<UserVO> userList = new List<UserVO>();
        userList = Controller.userList(userList);
        ui.Get().mainMenu(userList);
    }
}
