﻿namespace _30._01___parking_samochodowy;

class Program
{
            // Zadanie: Napisz program, który symuluje działanie parkingu samochodowego.
            // Utwórz typ wyliczenia Color, który zawiera pięć kolorów: Red, Blue, Green, Black, White.
    
    // Utwórz klasę Car, która reprezentuje samochód. Klasa ta powinna mieć następujące właściwości tylko do odczytu:
    // Brand (marka), Model (model), Year (rok produkcji), Color (kolor). 
    
    // Klasa ta powinna mieć również metodę ShowInformation, która wyświetla informacje o
    // samochodzie na konsoli w formacie: This is {Brand} {Model} from {Year}, color {Color}.
    
    // Utwórz klasę Parking, która reprezentuje parking samochodowy.
    // Klasa ta powinna mieć następujące właściwości: Name (nazwa parkingu), Cars (tablica samochodów, które znajdują się na parkingu).
    // Klasa ta powinna mieć również następujące metody: AddCar, która dodaje samochód do pierwszego wolnego miejsca
    // na parkingu (lub wyświetla komunikat, że nie ma wolnych miejsc), RemoveCar, która usuwa samochód z podanego indeksu miejsca
    // na parkingu (lub wyświetla komunikat, że podany indeks jest nieprawidłowy lub miejsce jest puste), ShowCars,
    // która wyświetla informacje o wszystkich samochodach na parkingu (lub informuje, że miejsce jest wolne).
    
    // Utwórz obiekty typu Car dla trzech różnych samochodów, używając inicjalizatorów obiektów.
    
    // Utwórz obiekt typu Parking dla parkingu o nazwie Center i pięciu miejscach, używając inicjalizatora obiektów.
    
    // Dodaj trzy samochody do parkingu, używając metody AddCar.
    
    // Wyświetl informacje o wszystkich samochodach na parkingu, używając metody ShowCars.
    
    // Usuń samochód z drugiego miejsca na parkingu, używając metody RemoveCar.
    
    // Wyświetl informacje o wszystkich samochodach na parkingu po usunięciu, używając metody ShowCars.
    
    static void Main(string[] args)
    {
        Car car = new Car("Ferrari", "Testarossa", 1960, Car.Color.Red);
        Console.WriteLine(car.ShowInformation());

        Parking parking = new Parking(5, "Mosina");
        
        parking.AddCar(3, car);
        
        
        parking.ShowCars();
    }
}
