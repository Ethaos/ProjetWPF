using ProjetWPF.Metier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ProjetWPF.DAO
{
    internal class CategoryDAO : DAO<Category>
    {
        public CategoryDAO() { }
        public override bool Create(Category obj)
        {
            return false;
        }
        public override bool Delete(Category obj)
        {
            return false;
        }
        public override bool Update(Category obj)
        {
            return false;
        }

        public override List<Category> FindAll()
        {
            List<Category> listCategory = null;

            return listCategory;
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
    }
}
