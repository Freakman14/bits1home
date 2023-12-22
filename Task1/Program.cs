var b1 = new Book();
b1.Title = "Power book";
b1.Author = "Shekspir";
b1.Year = 2019;
b1.GetInfo();
System.Console.WriteLine(b1.IsPublishedRecently());
public class Book
{
    public string Title;
    public string Author;
    public int Year;

    public Book(string title, string author, int year)
    {
        title = Title;
        author = Author;
        year = Year;
    }

    public Book()
    {
    }

    public void GetInfo()
    {
        System.Console.WriteLine($"Название: {Title}, Автор: {Author}, Год издание: {Year}");
    }
    public bool IsPublishedRecently()
    {
        bool ispub = true;
        bool _ispub = false;
        if (Year > 2010)
        {
            return ispub;
        }
        else{
            return _ispub;
        }
    }
}
