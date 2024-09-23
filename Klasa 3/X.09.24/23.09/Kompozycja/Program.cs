using Kompozycja.classes;

namespace Kompozycja;

class Program
{
    static void Main(string[] args)
    {
        Author author = new Author("Adam", "Mickiewicz");
        Book book = new Book("Tytul", author, 2022);
    }
}