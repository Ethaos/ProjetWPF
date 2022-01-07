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

        public override bool Update(Vehicle obj)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("update dbo.Vehicle set nbrPlacesmembers = @nbrMember, nbrPlacesBikes = @nbrBike WHERE idVehicle = @id)",
                        connection);
                    cmd.Parameters.AddWithValue("id", obj.Id);
                    cmd.Parameters.AddWithValue("nbrMember", obj.PMember);
                    cmd.Parameters.AddWithValue("nbrBike", obj.PBike);
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
                                Id = reader.GetInt32("idVehicle"),
                                PMember = reader.GetInt32("nbrPlacesmembers"),
                                PBike = reader.GetInt32("nbrPlacesBikes"),
                                Ride = reader.GetInt32("idRide"),
                                Driver = reader.GetInt32("idMember")
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
                                Id = reader.GetInt32("idVehicle"),
                                PMember = reader.GetInt32("nbrPlacesmembers"),
                                PBike = reader.GetInt32("nbrPlacesBikes"),
                                Ride = reader.GetInt32("idRide"),
                                Driver = reader.GetInt32("idMember")
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

        
    }
}
