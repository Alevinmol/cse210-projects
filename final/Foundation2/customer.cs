using System;
using System.ComponentModel;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public void GetAddress()
    {
        string address = _address.AllFields();
        Console.WriteLine(_name);
        Console.WriteLine(address);
    }

    public bool USAorNot()
    {
        if (_address.IsInUSA())
        {
            return true;
        }
        else return false;
    }
}