using ProjetWPF.Metier;
using System;
using System.Collections.Generic;
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
                        "(num,placeDeparture,dateDeparture,packageFee,idCategory) " +
                        "values('" + r.Num + "' , '" + r.PlaceDeparture + "' , '" + r.DateDeparture + "'" +
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
        public override bool Delete(Ride obj)
        {
            return false;
        }
        public override bool Update(Ride obj)
        {
            return false;
        }

        public override List<Ride> FindAll()
        {
            return null;
        }

        public override Ride Find(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Ride> FindBy(int id)
        {
            throw new NotImplementedException();
        }
    }
}
