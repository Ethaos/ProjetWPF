using System.Collections.Generic;

public class Member : Person
{
    private double balance;
    private List<Category> lcat = new List<Category>();
    private List<Bike> lbike = new List<Bike>();

    public Member(int id, string name, string firstname, int tel, string login, string password, double balance) : base(id, name, firstname, tel, login, password)
    {
        this.balance = balance;
    }

    public double Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public List<Category> LCat
    {
        get { return lcat; }
        set { lcat = value; }
    }

    public List<Bike> LBike
    {
        get { return lbike; }
        set { lbike = value; }
    }

    public void calculBalance()
    {

    }

    public void verifyBalance()
    {

    }


}
