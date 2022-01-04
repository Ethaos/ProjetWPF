using ProjetWPF.Metier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ProjetWPF.DAO
{
    internal class MemberDAO : DAO<Member>
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
        public override bool Delete(Member m)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE from dbo.Member WHERE idMember = @id ",connection);
                    cmd.Parameters.AddWithValue("id", m.Id);
                    if (m.Id == 0)
                    {
                        throw new Exception("No member deleted");
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

        public override bool Update(Member obj)
        {
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
                                PassWord = reader.GetString("passWord"),
                                Balance = reader.GetFloat("balance"),
                                Login = reader.GetString("login"),
                                Category = new List<Category>()
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

        public override List<Member> FindAll()
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
                                PassWord = reader.GetString("passWord"),
                                Balance = reader.GetFloat("balance"),
                                Login = reader.GetString("login")
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
    }
}
