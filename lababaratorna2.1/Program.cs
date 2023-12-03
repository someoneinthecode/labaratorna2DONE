class Program
{
    static void Main()
    {
        // Створення екземпляра класу Converter
        Converter converter = new Converter(28.3, 33.1, 7.5);

        // Приклад конвертації гривні в USD
        double amountInUah = 1000;
        double convertedToUsd = converter.ConvertToCurrency(amountInUah, "USD");
        Console.WriteLine($"{amountInUah} гривень дорівнюють {convertedToUsd} USD");

        // Приклад конвертації USD в гривню
        double amountInUsd = 50;
        double convertedToUah = converter.ConvertFromCurrency(amountInUsd, "USD");
        Console.WriteLine($"{amountInUsd} USD дорівнюють {convertedToUah} гривень");

        Console.ReadLine(); // для того, щоб консольне вікно не закрилося відразу
    }
}
