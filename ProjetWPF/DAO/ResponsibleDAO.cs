using System;
using System.Data;
using System.Data.SqlClient;

public class ResponsibleDAO : DAO<Responsible>
{
    public ResponsibleDAO() { }
    public override bool Create(Responsible obj)
    {
        return false;
    }
    public override bool Update(Responsible obj)
    {
        return false;
    }
    public override bool Delete(Responsible obj)
    {
        return false;
    }
    public override Responsible Find(int id)
    {

        Responsible responsible = null;

        try
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Responsible WHERE idResponsable = @id", connection);
                cmd.Parameters.AddWithValue("id", id);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        responsible = new Responsible
                        {
                            Id = reader.GetInt32("idResponsible"),
                            Name = reader.GetString("name"),
                            FirstName = reader.GetString("firstName"),
                            Tel = reader.GetInt32("tel"),
                            PassWord = reader.GetString("passWord"),
                            Login = reader.GetString("login"),
                            IdCategory = reader.GetInt32("idCategory")
                        };
                    }
                }
            }
        }
        catch (SqlException)
        {
            throw new Exception("Une erreur sql s'est produite!");
        }
        return responsible;
    }
    public Responsible LoginCheck(string login, string password)
    {
        Responsible responsible = null;
        try
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand("Select *  from dbo.Responsible where passWord = @pw and login = @login",
                    connection);
                cmd.Parameters.AddWithValue("pw", password);
                cmd.Parameters.AddWithValue("login", login);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        responsible = new Responsible
                        {
                            Id = reader.GetInt32("idResponsible"),
                            Name = reader.GetString("name"),
                            FirstName = reader.GetString("firstName"),
                            Tel = reader.GetInt32("tel"),
                            PassWord = reader.GetString("passWord"),
                            Login = reader.GetString("login"),
                            IdCategory = reader.GetInt32("idCategory")
                        };
                    }
                }
            }
        }
        catch (SqlException)
        {
            throw new Exception("Une erreur sql s'est produite!");
        }
        return responsible;
    }
}
    
