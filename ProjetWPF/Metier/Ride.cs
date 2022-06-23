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

    public int Num
    {
        get { return num; }
        set { num = value; }
    }

    public string PlaceDeparture
    {
        get { return placeDeparture; }
        set { placeDeparture = value; }
    }

    public string DateDeparture
    {
        get { return dateDeparture; }
        set { dateDeparture = value; }
    }

    public double PackageFee
    {
        get { return packageFee; }
        set { packageFee = value; }
    }

    public int IdCategory
    {
        get { return idCategory; }
        set { idCategory = value; }
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
