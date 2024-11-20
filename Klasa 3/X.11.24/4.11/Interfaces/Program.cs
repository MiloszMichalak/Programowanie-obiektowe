using Interfaces.Classes;

namespace Interfaces;

class Program
{
    static void Main(string[] args)
    {
        List<Book> books =
        [
            new Book(30, "Pan tadzio", "Adas", 1834),
            new Book(20, "Qlo wadis", "Juliusz", 1943),
            new Book(10, "Adzio", "Andrju", 1342),
            new Book(40, "Pan wesele", "Stachu", 2024)
        ];

        Console.WriteLine("Lista ksiazek");
        books.ForEach(Console.WriteLine);
        
        books.Sort();

        Console.WriteLine("\nPosortowane ksiazki wedlug ceny");
        books.ForEach(Console.WriteLine);
        
        var sortedByYear = books.OrderBy(book => book.publishYear);
        Console.WriteLine("\nPosortowane ksiazki wedlug roku wydania");
        foreach (Book book in sortedByYear)
        {
            Console.WriteLine(book);
        }
        
        var sortedByAuthor = books.OrderByDescending(book => book.author);
        Console.WriteLine("\nPosortowane ksiazki wedlug autora malejaco");
        foreach (Book book in sortedByAuthor)
        {
            Console.WriteLine(book);
        }
        
        var sortedByPriceAndYear = books
            .OrderByDescending(b => b.price)
            .ThenBy(b => b.publishYear);
        
        Console.WriteLine("\nPosortowane ksiazki wedlug ceny malejaco i roku wydania rosnaco");
        foreach (Book book in sortedByPriceAndYear)
        {
            Console.WriteLine(book);
        }
    }
}