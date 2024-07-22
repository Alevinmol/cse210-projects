using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvidence;
    private string _country;

    public Address(string street, string city, string stateOrProvidence, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvidence = stateOrProvidence;
        _country = country;
    }

    public bool IsInUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else return false;
    }

    public string AllFields()
    {
        string address = $"{_street} \n{_city}, {_stateOrProvidence}, {_country}.";
        return address;
    }
}