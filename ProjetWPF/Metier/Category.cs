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
}
