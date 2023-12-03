using System;
class Address
{
    private string index;
    private string country;
    private string city;
    private string street;
    private string house;
    private string apartment;

    // Властивість для індексу
    public string Index
    {
        get { return index; }
        set { index = value; }
    }

    // Властивість для країни
    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    // Властивість для міста
    public string City
    {
        get { return city; }
        set { city = value; }
    }

    // Властивість для вулиці
    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    // Властивість для будинку
    public string House
    {
        get { return house; }
        set { house = value; }
    }

    // Властивість для квартири
    public string Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    }
}
