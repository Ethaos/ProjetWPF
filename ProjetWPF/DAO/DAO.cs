using ProjetWPF.Metier;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace ProjetWPF.DAO
{
    internal abstract class DAO<T>
    {
        protected string connectionString = null;
        public DAO()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["ProjetWPF"].ConnectionString;
        }
        public abstract bool Create(T obj);
        public abstract bool Delete(T obj);
        public abstract bool Update(T obj);
        public abstract T Find(int id);
        public abstract bool Add(int a, int b);
        public abstract List<T> FindBy(int id); //Utilisé dans CatégoryDAO
        public abstract List<T> FindAll();//Utilisé pour trouver tous les lignes d'une table

        public abstract T LoginCheck(string a, string b);
        
    }
}
