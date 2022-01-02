using ProjetWPF.Metier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ProjetWPF.DAO
{
    internal class MemberDAO : DAO<Member>
    {
        public MemberDAO() { }
        public override bool Create(Member obj)
        {
            return false;
        }
        public override bool Delete(Member obj)
        {
            return false;
        }
        public override bool Update(Member obj)
        {
            return false;
        }

        public List<Member> FindAll()
        {
            List<Member> member = new List<Member>();
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
                                Balance = reader.GetInt32("balance"),
                                Category = new List<Category>()
                            };
                            member.Add(mem);
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
    }
}
