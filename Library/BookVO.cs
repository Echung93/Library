﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class BookVO
    {
    private string id;
    private string name;
    private string publisher;
    private string author;
    private string price;
    private string quantity;

    public BookVO()
    {

    }

    public BookVO(string id, string name, string publisher, string author, string price, string quantity)
    {
        this.id = id;
        this.name = name;
        this.publisher = publisher;
        this.price = price;
        this.quantity = quantity;
        this.author = author;
    }

    public string ID
    {
        get { return id;}
        set { id = value;}
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Publisher
    {
        get { return publisher; }
        set { publisher = value; }
    }

    public string Price
    {
        get { return price; }
        set { price = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public string Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

}


