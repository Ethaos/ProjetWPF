using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetWPF.DAO
{
    internal abstract class DAO<T>
    {
        protected string connectionString = null;
        public DAO()
        {
            //this.connectionString = ConfigurationManager.ConnectionStrings["SchoolDB"].ConnectionString;
        }
        public abstract bool Create(T obj);
        public abstract bool Delete(T obj);
        public abstract bool Update(T obj);
        public abstract T Find(int id);
    }
}
