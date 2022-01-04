using ProjetWPF.Metier;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ProjetWPF.DAO
{
    internal class ResponsibleDAO : DAO<Responsible>
    {
        public ResponsibleDAO() { }
        public override bool Create(Responsible obj)
        {
            return false;
        }
        public override bool Delete(Responsible obj)
        {
            return false;
        }
        public override bool Update(Responsible obj)
        {
            return false;
        }

        public override List<Responsible> FindAll()
        {
            /*
            List<Responsible> listResponsible = new List<Responsible>();
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Responsible", connection);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Responsible cat = new Responsible
                            {
                                Num = reader.GetInt32("num"),
                                NameResponsible = reader.GetString("nameResponsible"),
                                NameUnderResponsible = reader.GetString("nameUnderResponsible")
                            };
                            listResponsible.Add(cat);
                        }
                    }
                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }
            return listResponsible;*/
        }

        public override Responsible Find(int id)
        {
            Responsible responsible = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Responsible WHERE num = @id", connection);
                    cmd.Parameters.AddWithValue("id", id);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            responsible = new Responsible
                            {
                                Num = reader.GetInt32("num"),
                                NameResponsible = reader.GetString("nameResponsible"),
                                NameUnderResponsible = reader.GetString("nameUnderResponsible")

                            };
                        }
                    }
                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }
            return Responsible;
        }
    }
}
