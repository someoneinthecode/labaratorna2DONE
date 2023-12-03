using System;

class Converter
{
    private double usdRate;
    private double eurRate;
    private double plnRate;

    // Конструктор класу
    public Converter(double usd, double eur, double pln)
    {
        usdRate = usd;
        eurRate = eur;
        plnRate = pln;
    }

    // Метод для конвертації гривні в одну з валют
    public double ConvertToCurrency(double amount, string currency)
    {
        switch (currency.ToUpper())
        {
            case "USD":
                return amount / usdRate;
            case "EUR":
                return amount / eurRate;
            case "PLN":
                return amount / plnRate;
            default:
                Console.WriteLine("Непідтримувана валюта");
                return 0;
        }
    }

    // Метод для конвертації з валют до гривні
    public double ConvertFromCurrency(double amount, string currency)
    {
        switch (currency.ToUpper())
        {
            case "USD":
                return amount * usdRate;
            case "EUR":
                return amount * eurRate;
            case "PLN":
                return amount * plnRate;
            default:
                Console.WriteLine("Непідтримувана валюта");
                return 0;
        }
    }
}
