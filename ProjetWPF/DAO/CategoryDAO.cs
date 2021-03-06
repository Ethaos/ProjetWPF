using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class CategoryDAO : DAO<Category>
{
    public CategoryDAO() { }
    public override bool Create(Category obj)
    {
        return false;
    }
    public override bool Update(Category obj)
    {
        return false;
    }
    public override bool Delete(Category obj)
    {
        return false;
    }
    public override Category Find(int id)
    {
        Category category = null;

        try
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Category WHERE num = @id", connection);
                cmd.Parameters.AddWithValue("id", id);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        category = new Category
                        {
                            Num = reader.GetInt32("num"),
                            NameCategory = reader.GetString("nameCategory"),
                            NameUnderCategory = reader.GetString("nameUnderCategory")
                        };
                    }
                }
            }
        }
        catch (SqlException)
        {
            throw new Exception("Une erreur sql s'est produite!");
        }
        return category;
    }
    public List<Category> FindAll()
    {
        List<Category> listCategory = new List<Category>();
        try
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Category", connection);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Category cat = new Category
                        {
                            Num = reader.GetInt32("num"),
                            NameCategory = reader.GetString("nameCategory"),
                            NameUnderCategory = reader.GetString("nameUnderCategory")
                        };
                        listCategory.Add(cat);
                    }
                }
            }
        }
        catch (SqlException)
        {
            throw new Exception("Une erreur sql s'est produite!");
        }
        return listCategory;
    }
    public List<Category> FindBy(int id)
    {
        List<Category> listCategory = new List<Category>();

        try
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * from dbo.Category C join dbo.infoCatMember INFO " +
                    "on C.num = INFO.idCategory join dbo.Member M on INFO.idMember = M.idMember where M.idMember = @id", connection);
                cmd.Parameters.AddWithValue("id", id);

                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Category cat = new Category
                        {
                            Num = reader.GetInt32("num"),
                            NameCategory = reader.GetString("nameCategory"),
                            NameUnderCategory = reader.GetString("nameUnderCategory")
                        };
                        listCategory.Add(cat);
                    }
                }
            }
        }
        catch (SqlException)
        {
            throw new Exception("Une erreur sql s'est produite!");
        }
        return listCategory;
    }
}
