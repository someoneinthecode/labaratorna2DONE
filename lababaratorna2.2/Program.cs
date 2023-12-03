class Program
{
    static void Main()
    {
        // Створення екземпляру класу Employee
        Employee employee = new Employee("Іванов", "Петро");

        // Виклик методу для розрахунку окладу та податкового збору
        employee.CalculateSalary("middle", 5);

        Console.ReadLine(); // для того, щоб консольне вікно не закрилося відразу
    }
}
