public class Responsible : Person
{
    private int idCategory { get; set; }

    public Responsible(int id, string name, string firstname, int tel, string login, string password, int idCategory) : base(id, name, firstname, tel, login, password)
    {
        this.idCategory = idCategory;
    }

    public int IdCategory
    {
        get { return idCategory; }
        set { idCategory = value; }
    }
}
