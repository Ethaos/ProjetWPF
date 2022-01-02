using ProjetWPF.Metier;
using System;
using System.Collections.Generic;
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

        public override Category Find(int id)
        {
            Category category = null;
            /*
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Classes WHERE cls_id = @id", connection);
                    cmd.Parameters.AddWithValue("id", id);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            member = new Member
                            {
                                Name = reader.GetString("Nom de la colonne je pense"),
                                FirstName = reader.GetString(""),
                                Tel = reader.GetInt32(""),
                                PassWord = reader.GetString(""),
                                Balance = reader.GetInt32(""),
                                Category = new List<Category>(),
                                Bike = new List<Bike>()
                            };
                        }
                    }
                }
                if (member != null)
                {
                    CategoryDAO categoryDAO = new CategoryDAO();
                    List<Category> CategroyMember = categoryDAO.FindAll(member);
                    foreach (Category cat in CategroyMember)
                        member.Category.Add(cat);
                    BikeDAO bikeDAO = new BikeDAO();
                    List<Bike> BikeMember = bikeDAO.FindAll(member);
                    foreach (Bike bike in BikeMember)
                        member.Bike.Add(bike);
                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }*/
            return category;
        }
    }
}
