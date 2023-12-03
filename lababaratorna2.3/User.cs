using System;

class User
{
    private string login;
    private string firstName;
    private string lastName;
    private int age;
    private readonly DateTime registrationDate;

    // Конструктор класу
    public User(string login, string firstName, string lastName, int age)
    {
        this.login = login;
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.registrationDate = DateTime.Now; // Ініціалізація дати заповнення анкети
    }

    // Метод для виведення інформації про користувача на екран
    public void DisplayUserInfo()
    {
        Console.WriteLine($"Логін: {login}");
        Console.WriteLine($"Ім'я: {firstName}");
        Console.WriteLine($"Прізвище: {lastName}");
        Console.WriteLine($"Вік: {age}");
        Console.WriteLine($"Дата заповнення анкети: {registrationDate}");
    }
}

