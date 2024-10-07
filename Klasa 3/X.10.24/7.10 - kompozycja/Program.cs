using Kompozycja.classes;

namespace Kompozycja;

class Program
{
    static void Main(string[] args)
    {
        Author author = new Author("Adam", "Mickiewicz");
        Author author2 = new Author("Henryk", "Sienkiewicz");
        
        Book book = new Book("Tytul", author, 2022);
        Book book2 = new Book("Quo Vadis", author2, 1896);

        author.AddBook(book);
        author2.AddBook(book2);
        
        Library library = new Library();
        
        library.addBook(book);
        library.addBook(book2); 
        
        library.addAuthor(author);
        library.addAuthor(author2);

        Reader reader = new Reader("Jan", "Kowalski");
        Reader reader2 = new Reader("Bartosz", "Nowak");
        
        library.addReader(reader);
        library.addReader(reader2);
    }
}