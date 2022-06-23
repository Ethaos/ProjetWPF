using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class InscriptionDAO : DAO<Inscription>
{
    public InscriptionDAO() { }

    public override bool Create(Inscription i)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT into dbo.Inscription " +
                    "(passenger, bike, idRide, idMember) " +
                    "values('" + i.Passenger + "' , '" + i.Bikes + "'  , '" + i.IdRide + "', '" + i.IdMember + "' )",
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
    public override bool Update(Inscription obj)
    {
        return false;
    }
    public override bool Delete(Inscription obj)
    {
        return false;
    }
    public override Inscription Find(int id)
    {
        return null;
    }
    public List<Inscription> FindAll()
    {
        return null;
    }
    public List<Inscription> FindBy(int id)
    {
        List<Inscription> listInscription = new List<Inscription>();

        try
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * from dbo.Inscription WHERE idMember = @id", connection);
                cmd.Parameters.AddWithValue("id", id);

                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Inscription inscription = new Inscription
                        {
                            IdMember = reader.GetInt32("idMember"),
                            IdRide = reader.GetInt32("idRide"),
                            Passenger = reader.GetInt32("passenger"),
                            Bikes = reader.GetInt32("bike")
                        };
                        listInscription.Add(inscription);
                    }
                }
            }
        }
        catch (SqlException)
        {
            throw new Exception("Une erreur sql s'est produite!");
        }
        return listInscription;
    }
}
