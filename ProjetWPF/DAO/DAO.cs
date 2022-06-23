using System.Collections.Generic;
using System.Configuration;

namespace ProjetWPF.DAO
{
    public abstract class DAO<T>
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
        public abstract List<T> FindBy(int id); 
        public abstract List<T> FindByMember(int id); 
        public abstract List<T> FindAll();

        public abstract T LoginCheck(string a, string b);
        
    }
}
