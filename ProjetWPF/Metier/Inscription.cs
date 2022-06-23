public class Inscription
{
    private int idMember { get; set; }
    private int idRide { get; set; }
    private int passenger { get; set; }
    private int bikes { get; set; }

    public Inscription(int idMember, int idRide, int passenger, int bikes)
    {
        this.idMember = idMember;
        this.idRide = idRide;
        this.passenger = passenger;
        this.bikes = bikes;
    }

    public int IdMember
    {
        get { return idMember; }
        set { idMember = value; }
    }

    public int IdRide
    {
        get { return idRide; }
        set { idRide = value; }
    }

    public int Passenger
    {
        get { return passenger; }
        set { passenger = value; }
    }

    public int Bikes
    {
        get { return bikes; }
        set { bikes = value; }
    }

}
