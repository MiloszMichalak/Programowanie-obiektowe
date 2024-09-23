namespace Kompozycja.classes;

public class Author : Person
{
    List<Book> BookList = new List<Book>();
    public Author(string firstName, string lastName) : base(firstName, lastName)
    {
        BookList = new List<Book>();
    }

    public void AddBook(Book book)
    {
        BookList.Add(book);
    }
    
    
}