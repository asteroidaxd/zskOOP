public class Book
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int Pages { get; private set; }

   
    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    public Book() : this("Cursed book", "Anonim", 2137)
    {
    }

    public string GetSummary()
    {
        return $"{Title} by {Author}, pages: {Pages}";
    }
}