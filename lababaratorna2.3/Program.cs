class Program
{
    static void Main()
    {
        // Створення екземпляру класу User
        User user = new User("user123", "Іван", "Петров", 25);

        // Виклик методу для виведення інформації про користувача на екран
        user.DisplayUserInfo();

        Console.ReadLine(); // для того, щоб консольне вікно не закрилося відразу
    }
}
