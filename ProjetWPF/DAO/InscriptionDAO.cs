using ProjetWPF.Metier;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ProjetWPF.DAO
{
    internal class InscriptionDAO : DAO<Inscription>
    {
        public InscriptionDAO() { }
        public override bool Add(int a, int b)
        {
            return false;
        }

        public override bool Create(Inscription obj)
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

        public override List<Inscription> FindAll()
        {
            return null;
        }

        public override List<Inscription> FindBy(int id)
        {
            return null;
        }

        public override bool Inscription(Inscription i)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT into dbo.infoCatMember " +
                        "(passenger, bike, idRide, idMember) " +
                        "values('" + i.Passenger + "' , '" + i.Bikes + "'  , '" + i.Ride + "', '" + i.Member + "' )",
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

        public override Inscription LoginCheck(string a, string b)
        {
            return null;
        }

        public override bool Update(Inscription obj)
        {
            return false;
        }
    }
}
