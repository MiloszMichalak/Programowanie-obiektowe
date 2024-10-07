namespace Kompozycja.classes;

public class Library
{
    public List<Reader> readers { get; set; }
    public List<Book> books { get; set; }
    public List<Author> authors { get; set; }

    public Library()
    {
        readers = new List<Reader>();
        books = new List<Book>();
        authors = new List<Author>();
    }

    public void addBook(Book book)
    {
        books.Add(book);
    }

    public void addReader(Reader reader)
    {
        readers.Add(reader);
    }

    public void addAuthor(Author author)
    {
        authors.Add(author);
    }

    public void BorrowBook(Reader reader, Book book)
    {
        if (books.Contains(book))
        {
            reader.BorrowBook(book);
            books.Remove(book);
        }
        else
        {
            Console.WriteLine("Ksiazka nie jest dostepna w bibliotece");
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Ksiazki w bibliotece");
        foreach (var book in books)
        {
            Console.WriteLine($"Nazwa: {book.Title} Autor: {book.Author} Rok publikacji: {book.PublicationYear}");
        }
    }
    
    // todo dodac metode wyswietlaca wszystkich autorow w formie tabeli

    public void DisplayAuthors()
    {
        Console.WriteLine("Autorzy w bibliotece");
        foreach (var author in authors)
        {
            Console.WriteLine($"Imie: {author.FirstName} Nazwisko: {author.LastName}");
        }
    }

    public void DisplayBorrowedBooks()
    {
        Console.WriteLine("Wypozyczone ksiazki");
        foreach (var reader in readers) 
        {
            foreach (var book in reader.BorrowedBooksList)
            {
                Console.WriteLine($"{book.Title} - {book.Author.FirstName} {book.Author.LastName}" +
                                  $"({book.PublicationYear}) wypozyczona przez {reader.FirstName} {reader.LastName}");
            }
        }
    }

}