using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ProjetWPF.DAO
{
    internal class BikeDAO : DAO<Bike>
    {
        public override bool Create(Bike obj)
        {
            return false;
        }

        public override bool Delete(Bike obj)
        {
            return false;
        }

        public override bool Update(Bike obj)
        {
            return false;
        }

        public override Bike Find(int id)
        {
            return null;
        }

        public override List<Bike> FindAll()
        {
            return null;
        }

        public override List<Bike> FindBy(int id)
        {
            List<Bike>  listBike = new List<Bike>();

            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * from dbo.Bike WHERE idMember = @id", connection);
                    cmd.Parameters.AddWithValue("id", id);

                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Bike bike = new Bike
                            {
                                Weight = reader.GetDouble("weight"),
                                Type = reader.GetString("type"),
                                Length = reader.GetDouble("length")
                            };
                            listBike.Add(bike);
                        }
                    }
                }
                if (listBike.Count != 0)
                {
                    MemberDAO memberDAO = new MemberDAO();
                    Member m = memberDAO.Find(id);

                    m.LBike = listBike;
                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }
            return listBike;
        }

        public override Bike LoginCheck(string a, string b)
        {
            return null;
        }
        public override bool Add(int a, int b)
        {
            return false;
        }

        public override List<Bike> FindByMember(int id)
        {
            throw new NotImplementedException();
        }
    }
}
