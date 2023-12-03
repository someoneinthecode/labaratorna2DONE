class Program
{
    static void Main()
    {
        // Створення екземпляру класу Address
        Address myAddress = new Address();

        // Заповнення полів екземпляру інформацією про адресу
        myAddress.Index = "12345";
        myAddress.Country = "Україна";
        myAddress.City = "Київ";
        myAddress.Street = "Вулиця Примерна";
        myAddress.House = "1";
        myAddress.Apartment = "10";

        // Виведення інформації про адресу на екран
        Console.WriteLine($"Індекс: {myAddress.Index}");
        Console.WriteLine($"Країна: {myAddress.Country}");
        Console.WriteLine($"Місто: {myAddress.City}");
        Console.WriteLine($"Вулиця: {myAddress.Street}");
        Console.WriteLine($"Будинок: {myAddress.House}");
        Console.WriteLine($"Квартира: {myAddress.Apartment}");

        Console.ReadLine(); // для того, щоб консольне вікно не закрилося відразу
    }
}
