using dziedziczenie.classes;

namespace dziedziczenie;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Prostokat");
            Console.WriteLine("2. Kolo");
            Console.WriteLine("3. Trojkat");
            Console.WriteLine("4. Trapez");
            Console.WriteLine("5. Kula");
            Console.WriteLine("6. Wyjscie");

            Console.WriteLine("Wybierz ksztalt do obliczenia");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Rectangle rect = new Rectangle();
                    float rectWith = GetFloatFromUser("Podaj szerokosc: ");
                    float rectHeight = GetFloatFromUser("Podaj wysokosc: ");
                    rect.SetDimension(rectWith, rectHeight);
                    Console.WriteLine("Powierzchnia prostokata: {0}", rect.CalculateArea());
                    Console.WriteLine("Obwod prostokata: {0}", rect.CalculatePerimeter());
                    break;
                case 2:
                    float radius = GetFloatFromUser("Podaj promien: ");
                    Circle circle = new Circle(radius);
                    Console.WriteLine("Powierzchnia kola wynosi: {0}", circle.CalculateArea());
                    Console.WriteLine("Obwod kola wynosi: {0}", circle.CalculatePerimeter());
                    break;
                case 3:
                    float a, b, c;
                    do
                    {
                        a = GetFloatFromUser("Podaj dlugosc boku A: ");
                        b = GetFloatFromUser("Podaj dlugosc boku B: ");
                        c = GetFloatFromUser("Podaj dlugosc boku C: ");
                        if (!IsValidTriangle(a, b, c))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Nieprawidlowe dlugosci bokow. Sprobuj ponownie");
                            Console.ResetColor();
                        }
                    } while (!IsValidTriangle(a, b, c));
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Nieprawidlowy wybor, sprobuj ponownie.");
                    break;
            }
        }
    }

    private static bool IsValidTriangle(float a, float b, float c)
    {
        return (a + b > c) && (b + c > a) && (a + c > b);
    }

    private static float GetFloatFromUser(string message)
    {
        float wynik;
        Console.WriteLine(message);
        while (!(float.TryParse(Console.ReadLine(), out wynik) && wynik > 0))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nieprawidlowe wejscie, Sproboj ponownie.");
            Console.ResetColor();
            Console.Write(message);
        } 
        Console.ResetColor();
        return wynik;
    }
}