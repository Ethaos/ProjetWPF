using ProjetWPF.Metier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ProjetWPF.DAO
{
    internal class VehicleDAO : DAO<Vehicle>
    {
        public override bool Create(Vehicle v)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("insert into dbo.Vehicle (nbrPlacesMembers, nbrPlacesBikes, idRide, idMember) " +
                        "values('" + v.PMember + "' , '" + v.PBike + "' , '" + v.Ride + "' , '" + v.Driver + "')",
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

        public override bool Delete(Vehicle obj)
        {
            throw new NotImplementedException();
        }

        public override Vehicle Find(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Vehicle> FindAll()
        {
            throw new NotImplementedException();
        }

        public override List<Vehicle> FindBy(int id)
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
                                PMember = reader.GetInt32("place"),
                                PBike = reader.GetInt32("place"),
                                Ride = reader.GetInt32("place"),
                                Driver = reader.GetInt32("place")
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

        public override List<Vehicle> FindByMember(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Add(int a, int b)
        {
            throw new NotImplementedException();
        }

        public override Vehicle LoginCheck(string a, string b)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Vehicle obj)
        {
            throw new NotImplementedException();
        }
    }
}
