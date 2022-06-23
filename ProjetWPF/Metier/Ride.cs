public class Ride
{
    private int num { get; set; }
    private string placeDeparture { get; set; }
    private string dateDeparture { get; set; }
    private double packageFee { get; set; }
    private int idCategory { get; set; }

    public Ride(string placeDeparture, string dateDeparture, double packageFee, int idCategory)
    {
        this.placeDeparture = placeDeparture;
        this.dateDeparture = dateDeparture;
        this.packageFee = packageFee;
        this.idCategory = idCategory;
    }

    public Ride(int num, string placeDeparture, string dateDeparture, double packageFee, int idCategory)
    {
        this.num = num;
        this.placeDeparture = placeDeparture;
        this.dateDeparture = dateDeparture;
        this.packageFee = packageFee;
        this.idCategory = idCategory;
    }

    public void addParticipant()
    {

    }

    public void getTotalMemberPlaces()
    {

    }

    public void getRestMemberPlaces()
    {

    }

    public void getTotalBikePlaces()
    {

    }

    public void getRestBikePlaces()
    {

    }

    public void getMemberPlacesNeed()
    {

    }

    public void getBikePlacesNeed()
    {

    }

    public void addVehicle()
    {

    }
}
