public abstract class Person
{
    private int id { get; set; }
    private string name { get; set; }
    private string firstName { get; set; }
    private int tel { get; set; }
    private string login { get; set; }
    private string passWord { get; set; }

    public Person(int id, string name, string firstName, int tel, string login, string passWord)
    {
        this.id = id;
        this.name = name;
        this.firstName = firstName;
        this.tel = tel;
        this.login = login;
        this.passWord = passWord;
    }
}
