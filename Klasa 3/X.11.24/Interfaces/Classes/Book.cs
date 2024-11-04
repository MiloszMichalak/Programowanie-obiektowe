namespace Interfaces.Classes;

public class Book : IComparable<Book>
{
    public int price {get; set;}
    public string title {get; set;}
    public string author {get; set;}
    public int publishYear {get; set;}
    
    public Book(int price, string title, string author, int publishYear)
    {
        this.price = price;
        this.title = title;
        this.author = author;
        this.publishYear = publishYear;
    }
    
    public int CompareTo(Book? other)
    {
        if (other == null) return 1;
        return price.CompareTo(other.price);
    }

    public override string ToString()
    {
        return $"Title: {title}, Author: {author}, Price: {price}, Publish Year: {publishYear}";
    }
}