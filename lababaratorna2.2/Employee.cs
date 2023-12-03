using System;

class Employee
{
    private string lastName;
    private string firstName;

    // Конструктор класу
    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    // Метод для розрахунку окладу та податкового збору
    public void CalculateSalary(string position, int experience)
    {
        double baseSalary = 0;

        // Розрахунок окладу залежно від посади
        switch (position.ToLower())
        {
            case "junior":
                baseSalary = 30000;
                break;
            case "middle":
                baseSalary = 50000;
                break;
            case "senior":
                baseSalary = 80000;
                break;
            default:
                Console.WriteLine("Невідома посада");
                return;
        }

        // Збільшення окладу залежно від стажу
        if (experience > 0)
        {
            baseSalary += experience * 1000;
        }

        // Розрахунок податкового збору (припустимо, що це 15% від окладу)
        double tax = 0.15 * baseSalary;

        // Виведення інформації про співробітника, оклад та податковий збір
        Console.WriteLine($"Інформація про співробітника:");
        Console.WriteLine($"Прізвище: {lastName}");
        Console.WriteLine($"Ім'я: {firstName}");
        Console.WriteLine($"Посада: {position}");
        Console.WriteLine($"Оклад: {baseSalary:C}");
        Console.WriteLine($"Податковий збір: {tax:C}");
    }
}

