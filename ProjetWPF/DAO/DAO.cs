using System.Configuration;

public abstract class DAO<T>
{
    protected string connectionString = null;
    public DAO()
    {
        this.connectionString = ConfigurationManager.ConnectionStrings["ProjetWPF"].ConnectionString;
    }
    public abstract bool Create(T obj);
    public abstract bool Update(T obj);
    public abstract bool Delete(T obj);
    public abstract T Find(int id);
}
