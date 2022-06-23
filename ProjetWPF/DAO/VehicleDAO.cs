using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class VehicleDAO : DAO<Vehicle>
{
    public override bool Create(Vehicle v)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into dbo.Vehicle (nbrPlacesMembers, nbrPlacesBikes, idMember, idRide) " +
                    "values('" + v.NbrPlacesMembers + "' , '" + v.NbrPlacesBikes + "' , '" + v.IdDriver + "' , '" + v.IdRide + "')",
                    connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        catch (SqlException)
        {
            throw new Exception("Une erreur sql s'est produite!");
        }
        return false;
    }
    public override bool Update(Vehicle obj)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("update dbo.Vehicle set nbrPlacesmembers = @nbrMember, nbrPlacesBikes = @nbrBike WHERE idVehicle = @id",
                    connection);
                cmd.Parameters.AddWithValue("id", obj.IdVehicle);
                cmd.Parameters.AddWithValue("nbrMember", obj.NbrPlacesMembers);
                cmd.Parameters.AddWithValue("nbrBike", obj.NbrPlacesBikes);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        catch (SqlException)
        {
            throw new Exception("Une erreur sql s'est produite!");
        }
        return false;
    }
    public override bool Delete(Vehicle obj)
    {
        return false;
    }
    public override Vehicle Find(int id)
    {
        Vehicle vehicle = null;

        try
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * from dbo.Vehicle WHERE idVehicle = @id", connection);
                cmd.Parameters.AddWithValue("id", id);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        vehicle = new Vehicle
                        {
                            IdVehicle = reader.GetInt32("idVehicle"),
                            NbrPlacesMembers = reader.GetInt32("nbrPlacesmembers"),
                            NbrPlacesBikes = reader.GetInt32("nbrPlacesBikes"),
                            IdRide = reader.GetInt32("idRide"),
                            IdDriver = reader.GetInt32("idMember")
                        };
                    }
                }
            }
        }
        catch (SqlException)
        {
            throw new Exception("Une erreur sql s'est produite!");
        }
        return vehicle;
    }
    public List<Vehicle> FindBy(int id)
    {
        List<Vehicle> listVehicle = new List<Vehicle>();

        try
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * from dbo.Vehicle WHERE idRide = @id", connection);
                cmd.Parameters.AddWithValue("id", id);

                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Vehicle vehicle = new Vehicle
                        {
                            IdVehicle = reader.GetInt32("idVehicle"),
                            NbrPlacesMembers = reader.GetInt32("nbrPlacesmembers"),
                            NbrPlacesBikes = reader.GetInt32("nbrPlacesBikes"),
                            IdRide = reader.GetInt32("idRide"),
                            IdDriver = reader.GetInt32("idMember")
                        };
                        listVehicle.Add(vehicle);
                    }
                }
            }
        }
        catch (SqlException)
        {
            throw new Exception("Une erreur sql s'est produite!");
        }
        return listVehicle;
    }
}
