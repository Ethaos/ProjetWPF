﻿public class Bike
{
    private double weight { get; set; }
    private string type { get; set; }
    private double length { get; set; }

    public Bike() { }

    public Bike(double weight, string type, double length)
    {
        this.weight = weight;
        this.type = type;
        this.length = length;
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

}
