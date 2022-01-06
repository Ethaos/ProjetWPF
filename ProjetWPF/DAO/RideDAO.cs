using ProjetWPF.Metier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ProjetWPF.DAO
{
    internal class RideDAO : DAO<Ride>
    {
        public RideDAO() { }

        public override bool Create(Ride r)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT into dbo.Ride " +
                        "(placeDeparture,dateDeparture,packageFee,idCategory) " +
                        "values('" + r.PlaceDeparture + "' , '" + r.DateDeparture + "'" +
                        " , '" + r.PackageFee + "' , '" + r.IdCategory +"')",
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
        public override bool Delete(Ride r)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE from dbo.Ride WHERE num = @id ", connection);
                    cmd.Parameters.AddWithValue("num", r.Num);
                    if (r.Num == 0)
                    {
                        throw new Exception("No ride deleted");
                    }
                    else
                    {
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        return true;
                    }

                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }
            return false;
        }
        public override bool Update(Ride obj)
        {
            return false;
        }
        public override Ride Find(int id)
        {
            return null;
        }

        public override List<Ride> FindAll()
        {
            return null;
        }

        public override bool Add(int a, int b)
        {
            return false;
        }

        public override List<Ride> FindBy(int id)
        {
            List<Ride> listRide = new List<Ride>();

            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * from dbo.Ride WHERE idCategory = @id", connection);
                    cmd.Parameters.AddWithValue("id", id);

                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Ride ride = new Ride
                            {
                                Num = reader.GetInt32("num"),
                                PlaceDeparture = reader.GetString("placeDeparture"),
                                DateDeparture = reader.GetDateTime("dateDeparture"),
                                PackageFee = reader.GetFloat("packageFee"),
                                IdCategory = reader.GetInt32("idCategory")
                            };
                            listRide.Add(ride);
                        }
                    }
                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }
            return listRide;
        }

        public override Ride LoginCheck(string a, string b)
        {
            return null;
        }
    }
}
