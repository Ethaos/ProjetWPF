using System.Collections.Generic;

public class Bike
{
    private double weight; 
    private string type;
    private double length;
    private Member member;
    private List<Inscription> inscriptions = new List<Inscription>();

    public Bike() { }

    public Bike(double weight, string type, double length, Member member)
    {
        this.weight = weight;
        this.type = type;
        this.length = length;
        this.member = member;
    }

    public double Weight
    {
        get { return weight; } 
        set { weight = value; } 
    }

    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    public double Length
    {
        get { return length; }
        set { length = value; }
    }

    public Member Member
    {
        get { return member; }
        set { member = value; }
    }

    public List<Inscription> Inscriptions
    {
        get { return inscriptions; }
        set { inscriptions = value; }
    }
}
