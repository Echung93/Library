using System;
[Serializable]
public class BookVO
{
    private string bookIDNumber;
    private string bookName;
    private string bookPublisher;
    private string bookAuthor;
    private string bookPrice;
    private int bookQuantity;
    public BookVO()
    {

    }

    public BookVO(string bookIDNumber, string bookName, string bookPublisher, string bookAuthor, string bookPrice, int bookQuantity)
    {
        this.bookIDNumber = bookIDNumber;
        this.bookName = bookName;
        this.bookPublisher = bookPublisher;
        this.bookAuthor = bookAuthor;
        this.bookPrice = bookPrice;
        this.bookQuantity = bookQuantity;

    }

    public string BookIDNumber
    {
        get { return bookIDNumber; }
        set { bookIDNumber = value; }
    }

    public string BookName
    {
        get { return bookName; }
        set { bookName = value; }
    }

    public string BookPublisher
    {
        get { return bookPublisher; }
        set { bookPublisher = value; }
    }
    public string BookAuthor
    {
        get { return bookAuthor; }
        set { bookAuthor = value; }
    }

    public string BookPrice
    {
        get { return bookPrice; }
        set { bookPrice = value; }
    }


    public int BookQuantity
    {
        get { return bookQuantity; }
        set { bookQuantity = value; }
    }
}