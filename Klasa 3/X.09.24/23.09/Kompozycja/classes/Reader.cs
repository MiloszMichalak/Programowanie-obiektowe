namespace Kompozycja.classes;

public class Reader : Person
{
    public List<Book> BorrowedBooksList { get; set; }
    public Reader(string firstName, string lastName) : base(firstName, lastName)
    {
        BorrowedBooksList = new List<Book>();
    }

    public void AddBook(Book book)
    {
        BorrowedBooksList.Add(book);
        Console.WriteLine($"Czytelnik {FirstName} {LastName} wypozyczyl ksiazke: {book.Title}");
    }
    
    
}