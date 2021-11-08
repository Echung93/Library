using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Serializable]
class UserVO
{
    private string userId;
    private string userPassword;
    private string userName;
    private string userAge;
    private string userPhoneNumber;
    private string userAddress;
    private string borrowedBookList;
    private string borrowedBookCount;

    public string UserId
    {
        get { return userId; }
        set { userId = value; }
    }

    public string UserPassword
    {
        get { return userPassword; }
        set { userPassword = value; }
    }

    public string UserName
    {
        get { return userName; }
        set { userName = value; }
    }

    public string UserAge
    {
        get { return userAge; }
        set { userAge = value; }
    }

    public string UserPhoneNumber
    {
        get { return userPhoneNumber; }
        set { userPhoneNumber = value; }
    }

    public string UserAddress
    {
        get { return userAddress; }
        set { userAddress = value; }
    }

    public string BorrowedBookList
    {
        get { return borrowedBookList; }
        set { borrowedBookList = value; }
    }

    public string BorrowedBookCount
    {
        get { return borrowedBookCount; }
        set { borrowedBookCount = value; }
    }
}
