using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class MemberDAO : DAO<Member>
{
    public MemberDAO() { }
    public override bool Create(Member m)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT into dbo.Member " +
                    "(idMember,name,firstName,tel,passWord,balance,login) " +
                    "values('" + m.Id + "' , '" + m.Name + "' , '" + m.FirstName + "'" +
                    " , '" + m.Tel + "' , '" + m.PassWord + "' , '" + m.Balance + "' , '" + m.Login + "')",
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
    public override bool Update(Member obj)
    {
        return false;
    }
    public override bool Delete(Member m)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("DELETE from dbo.Member WHERE idMember = @id ", connection);
                cmd.Parameters.AddWithValue("id", m.Id);
                if (m.Id == 0)
                {
                    throw new Exception("No member deleted");
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        catch (SqlException)
        {
            throw new Exception("Une erreur sql s'est produite!");
        }
        return false;
    }
    public override Member Find(int id)
    {
        Member member = null;

        try
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Member WHERE idMember = @id", connection);
                cmd.Parameters.AddWithValue("id", id);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        member = new Member
                        {
                            Id = reader.GetInt32("idMember"),
                            Name = reader.GetString("name"),
                            FirstName = reader.GetString("firstName"),
                            Tel = reader.GetInt32("tel"),
                            Login = reader.GetString("login"),
                            PassWord = reader.GetString("passWord"),
                            Balance = reader.GetDouble("balance")
                        };
                    }
                }
            }
        }
        catch (SqlException)
        {
            throw new Exception("Une erreur sql s'est produite!");
        }
        return member;
    }
    public List<Member> FindAll()
    {
        List<Member> listMember = new List<Member>();
        try
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Member", connection);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Member mem = new Member
                        {
                            Id = reader.GetInt32("idMember"),
                            Name = reader.GetString("name"),
                            FirstName = reader.GetString("firstName"),
                            Tel = reader.GetInt32("tel"),
                            Login = reader.GetString("login"),
                            PassWord = reader.GetString("passWord"),
                            LCat = new List<Category>(),
                            LBike = new List<Bike>()
                        };
                        listMember.Add(mem);
                    }
                }
            }
        }
        catch (SqlException)
        {
            throw new Exception("Une erreur sql s'est produite!");
        }
        return listMember;
    }
    public bool Add(int idMember, int idCategory)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT into dbo.infoCatMember " +
                    "(idMember,idCategory) " +
                    "values('" + idMember + "' , '" + idCategory + "' )",
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
    public Member LoginCheck(string login, string password)
    {
        Member member = null;
        try
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {

                SqlCommand cmd = new SqlCommand("Select *  from dbo.Member where passWord = @pw and login = @login",
                    connection);
                cmd.Parameters.AddWithValue("pw", password);
                cmd.Parameters.AddWithValue("login", login);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        member = new Member
                        {
                            Id = reader.GetInt32("idMember"),
                            Name = reader.GetString("name"),
                            FirstName = reader.GetString("firstName"),
                            Tel = reader.GetInt32("tel"),
                            Login = reader.GetString("login"),
                            PassWord = reader.GetString("passWord"),
                            LCat = new List<Category>(),
                            LBike = new List<Bike>()
                        };
                    }
                }
            }
        }
        catch (SqlException)
        {
            throw new Exception("Une erreur sql s'est produite!");
        }
        return member;
    }
}
