public class Category
{
    private int num { get; set; }
    private string nameCategory { get; set; }
    private string nameUnderCategory { get; set; }

    public Category() { }

    public Category(int num, string nameCategory, string nameUnderCategory)
    {
        this.num = num;
        this.nameCategory = nameCategory;
        this.nameUnderCategory = nameUnderCategory;
    }

    public int Num
    {
        get { return num; }
        set { num = value; }
    }

    public string NameCategory
    {
        get { return nameCategory; }
        set { nameCategory = value; }
    }

    public string NameUnderCategory
    {
        get { return nameUnderCategory; }
        set { nameUnderCategory = value; }
    }
}
