public class Vehicle
{
    private int idVehicle { get; set; }
    private int nbrPlacesMembers { get; set; }
    private int nbrPlacesBikes { get; set; }
    private int idDriver { get; set; }
    private int idRide { get; set; }

    public Vehicle(int idVehicle, int nbrPlacesMembers, int nbrPlacesBikes, int idDriver, int idRide)
    {
        this.idVehicle = idVehicle;
        this.nbrPlacesMembers = nbrPlacesMembers;
        this.nbrPlacesBikes = nbrPlacesBikes;
        this.idDriver = idDriver;
        this.idRide = idRide;
    }

    public int IdVehicle
    {
        get { return idVehicle; }
        set { idVehicle = value; }
    }

    public int NbrPlacesMembers
    {
        get { return nbrPlacesMembers; }
        set { nbrPlacesMembers = value; }
    }

    public int NbrPlacesBikes
    {
        get { return nbrPlacesBikes; }
        set { nbrPlacesBikes = value; }
    }

    public int IdDriver
    {
        get { return idDriver; }
        set { idDriver = value; }
    }

    public int IdRide
    {
        get { return idRide; }
        set { idRide = value; }
    }

    public void addPassenger()
    {

    }

    public void addBike()
    {

    }
}
