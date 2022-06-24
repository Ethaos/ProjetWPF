public class Inscription
{
    private Member member;
    private Ride ride; 
    private bool passenger; 
    private bool bike; 

    public Inscription(Member member, Ride ride, bool passenger, bool bike)
    {
        this.member = member;
        this.ride = ride;
        this.passenger = passenger;
        this.bike = bike;
    }

    public Member Member
    {
        get { return member; }
        set { member = value; }
    }

    public Ride Ride
    {
        get { return ride; }
        set { ride = value; }
    }

    public bool Passenger
    {
        get { return passenger; }
        set { passenger = value; }
    }

    public bool Bike
    {
        get { return bike; }
        set { bike = value; }
    }

}
